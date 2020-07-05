using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace FormsControlLibrary
{
    public partial class SpellsListControl : UserControl
    {
        List<Spell> spells = new List<Spell>();

        public delegate List<Spell> SpellListHandler();
        public event SpellListHandler GetAllSpells;

        public delegate void CreateSpellHandler();
        public event CreateSpellHandler OnCreateSpell;
        public delegate void EditSpellHandler(Spell selectedSpell);
        public event EditSpellHandler OnEditSpell;
        public delegate void DeleteSpellHandler(Spell selectedSpell);
        public event DeleteSpellHandler OnDeleteSpell;

        public SpellsListControl(SpellListHandler getAllSpells)
        {
            InitializeComponent();

            GetAllSpells = getAllSpells;
            if (GetAllSpells != null)
            {
                spells = GetAllSpells();
            }

            foreach (Spell spell in spells)
            {
                dgvSpells.Rows.Add(spell.ID, spell.Level, spell.Class.Name, spell.Name, spell.Components);
            }
        }

        public void AddSpellToGrid(Spell newSpell)
        {
            dgvSpells.Rows.Add(newSpell.ID, newSpell.Level, newSpell.Class.Name, newSpell.Components);
        }

        public void EditSpellOnGrid(Spell currentSpell)
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
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            OnCreateSpell?.Invoke();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (OnEditSpell != null && dgvSpells.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvSpells.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvSpells.Rows[selectedrowindex];
                int selectedId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                Spell selectedSpell = spells.Find(u => u.ID == selectedId);
                OnEditSpell.Invoke(selectedSpell);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (OnDeleteSpell != null && dgvSpells.SelectedCells.Count > 0)
            {
                var confirmResult = MessageBox.Show("Esta seguro que desea borrar este hechizo?", "Confirmar borrado", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int selectedrowindex = dgvSpells.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvSpells.Rows[selectedrowindex];
                    int selectedId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    Spell selectedSpell = spells.Find(u => u.ID == selectedId);

                    OnDeleteSpell.Invoke(selectedSpell);

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
