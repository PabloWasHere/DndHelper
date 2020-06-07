using Controllers;
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

        bool usesSpellbook = false;

        public ManageSpells()
        {
            InitializeComponent();
        }

        public ManageSpells(Character character)
        {
            InitializeComponent();
            this.character = dbContext.Characters.SingleOrDefault(c => c.ID == character.ID);
        }

        private void ManageSpells_Load(object sender, EventArgs e)
        {
            //spellbook = character.Class.Code == "WIZ";
            FillSpellsInfo();
        }

        private void FillSpellsInfo()
        {
            character = dbContext.Characters.Find(character.ID);

            addSpells = dbContext.Spells.Where(x => x.Class.ID == character.Class.ID && x.Level <= character.Level && x.Active == 1).OrderBy(x => x.Level).ToList();
            int c = 0;
            dgvAddSpells.Rows.Clear();
            foreach (Spell spell in addSpells)
            {
                dgvAddSpells.Rows.Add(spell.ID, spell.Level, spell.Name);
                if (!character.PreparedSpells.Where(x => x.Spell.Active == 1).Select(ps => ps.Spell).Contains(spell))
                {
                    DataGridViewButtonCell dgvbc = new DataGridViewButtonCell();
                    dgvbc.Value = "Agregar";
                    dgvbc.Style.BackColor = SystemColors.Control;
                    dgvAddSpells.Rows[c].Cells[3] = dgvbc;
                }
                else
                {
                    dgvAddSpells.Rows[c].Cells[3].Value = "Preparado";
                }
                c++;
            }

            preparedSpells = character.PreparedSpells.Where(x => x.Spell.Active == 1).Select(ps => ps.Spell).ToList();
            c = 0;
            dgvPreparedSpells.Rows.Clear();
            foreach (Spell spell in preparedSpells)
            {
                dgvPreparedSpells.Rows.Add(spell.ID, spell.Level, spell.Name);
                DataGridViewButtonCell dgvbc = new DataGridViewButtonCell();
                dgvbc.Value = "Remover";
                dgvbc.Style.BackColor = SystemColors.Control;
                dgvPreparedSpells.Rows[c].Cells[3] = dgvbc;
                c++;
            }
        }

        private void dgvAddSpells_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int selectedSpellId = (int) dgvAddSpells.Rows[e.RowIndex].Cells["asId"].Value;
                addFromSpellList(selectedSpellId);
                FillSpellsInfo();
            }
        }

        private void dgvPreparedSpells_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int selectedSpellId = (int)dgvPreparedSpells.Rows[e.RowIndex].Cells["psId"].Value;
                removeFromPreparedSpells(selectedSpellId);
                FillSpellsInfo();
            }
        }

        private void addFromSpellList(int spellId)
        {
            Spell selectedSpell = addSpells.Find(s => s.ID == spellId);
            if (!character.PreparedSpells.Where(x => x.Spell.Active == 1).Select(ps => ps.Spell).Contains(selectedSpell))
            {
                CharacterPreparedSpell preparedSpell = new CharacterPreparedSpell()
                {
                    Character = character,
                    Spell = selectedSpell
                };
                dbContext.CharacterPreparedSpells.Add(preparedSpell);
                dbContext.SaveChanges();
            }
        }

        private void removeFromPreparedSpells(int spellId)
        {
            CharacterPreparedSpell preparedSpell = character.PreparedSpells.First(ps => ps.Spell.ID == spellId);
            dbContext.CharacterPreparedSpells.Remove(preparedSpell);
            dbContext.SaveChanges();
        }

        private void addFromSpellbook(int spellId)
        {
            Spell selectedSpell = spellbook.Find(s => s.ID == spellId);
            if (!character.Spellbook.Where(x => x.Spell.Active == 1).Select(ps => ps.Spell).Contains(selectedSpell))
            {
                CharacterPreparedSpell preparedSpell = new CharacterPreparedSpell()
                {
                    Character = character,
                    Spell = selectedSpell
                };
                dbContext.CharacterPreparedSpells.Add(preparedSpell);
                dbContext.SaveChanges();
            }
        }

        private void removeFromSpellbook(int spellId)
        {
            CharacterSpellbook bookSpell = character.Spellbook.First(ps => ps.Spell.ID == spellId);
            dbContext.characterSpellbook.Remove(bookSpell);
            dbContext.SaveChanges();
        }
    }
}
