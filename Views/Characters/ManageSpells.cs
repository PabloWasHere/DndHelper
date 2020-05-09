using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Characters
{
    public partial class ManageSpells : Form
    {
        DndHelperContext dbContext = new DndHelperContext();
        Character character;

        List<Spell> addSpells = new List<Spell>();
        List<Spell> preparedSpells = new List<Spell>();
        List<Spell> spellbook = new List<Spell>();

        public ManageSpells()
        {
            InitializeComponent();
        }

        public ManageSpells(Character character)
        {
            InitializeComponent();
            this.character = character;
        }

        private void ManageSpells_Load(object sender, EventArgs e)
        {
            addSpells = dbContext.Spells.Where(x => x.Class.ID == character.Class.ID && x.Level <= character.Level).OrderBy(x => x.Level).ToList();
            int c = 0;
            foreach (Spell spell in addSpells)
            {
                dgvAddSpells.Rows.Add(spell.ID, spell.Level, spell.Name);
                DataGridViewButtonCell dgvbc = new DataGridViewButtonCell();
                dgvbc.Value = character.PreparedSpells.Contains(spell) ? "Listo" : "Agregar";
                dgvbc.Style.BackColor = SystemColors.Control;
                dgvAddSpells.Rows[c].Cells[3] = dgvbc;
                c++;
            }
        }

        private void dgvAddSpells_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                MessageBox.Show((e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
            }
        }
    }
}
