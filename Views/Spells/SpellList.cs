using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Domain;

namespace Views.Spells
{
    public partial class SpellList : Form
    {
        DndHelperContext dbContext = new DndHelperContext();
        List<Spell> spells = new List<Spell>();
        public SpellList()
        {
            InitializeComponent();
        }

        private void SpellList_Load(object sender, EventArgs e)
        {
            Domain.User loggedUser = Session.GetInstance().LoggedUser;
            spells = dbContext.Spells.Where(x => x.Custom == 1 && x.Owner == loggedUser).OrderBy(x => x.Level).ToList();
            foreach (Spell spell in spells)
            {
                dgvSpells.Rows.Add(spell.ID, spell.Level, spell.Class.Name, spell.Name, spell.Components);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SpellCreate spellCreateForm = new SpellCreate((Spell newSpell) =>
            {
                dgvSpells.Rows.Add(newSpell.ID, newSpell.Level, newSpell.Class.Name, newSpell.Components);
            });
            spellCreateForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSpells.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvSpells.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvSpells.Rows[selectedrowindex];
                int selectedId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                Spell selectedSpell = spells.Find(u => u.ID == selectedId);
                SpellEdit spellEditForm = new SpellEdit(selectedSpell, (Spell currentSpell) =>
                {
                    foreach (DataGridViewRow row in dgvSpells.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["id"].Value) == currentSpell.ID)
                        {
                            row.Cells["level"].Value = currentSpell.Level;
                            row.Cells["charClass"].Value = currentSpell.Class.Name;
                            row.Cells["name"].Value = currentSpell.Name;
                            row.Cells["materials"].Value = currentSpell.Components;
                            break;
                        }
                    }
                    dgvSpells.Refresh();
                });
                spellEditForm.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSpells.SelectedCells.Count > 0)
            {
                var confirmResult = MessageBox.Show("Esta seguro que desea borrar este hechizo?", "Confirmar borrado", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int selectedrowindex = dgvSpells.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvSpells.Rows[selectedrowindex];
                    int selectedId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    Spell selectedSpell = spells.Find(u => u.ID == selectedId);

                    selectedSpell.Active = 0;
                    selectedSpell.Modified = DateTime.Now;
                    selectedSpell.ModificationUser = Session.GetInstance().LoggedUser;
                    dbContext.SaveChanges();

                    foreach (DataGridViewRow item in dgvSpells.SelectedRows)
                    {
                        dgvSpells.Rows.RemoveAt(item.Index);
                    }
                    dgvSpells.Refresh();
                }
            }
        }
    }
}
