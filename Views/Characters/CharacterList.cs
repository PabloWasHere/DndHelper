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
    public partial class CharacterList : Form
    {
        DndHelperContext dbContext = new DndHelperContext();
        List<Character> characters = new List<Character>();
        public CharacterList()
        {
            InitializeComponent();
        }

        private void CharacterList_Load(object sender, EventArgs e)
        {
            characters = dbContext.Characters.Where(x => x.Active == 1).ToList();
            foreach (Character character in characters)
            {
                dgvCharacters.Rows.Add(character.ID, character.Name, character.Race.Name, character.Class.Name, character.Level.ToString());
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CharacterCreate characterCreate = new CharacterCreate(null, Close);
            characterCreate.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCharacters.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvCharacters.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvCharacters.Rows[selectedrowindex];
                int selectedId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                Character selectedChar = characters.Find(u => u.ID == selectedId);
                CharacterCreate characterCreate = new CharacterCreate(selectedChar, Close);
                characterCreate.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCharacters.SelectedCells.Count > 0)
            {
                var confirmResult = MessageBox.Show("Esta seguro que desea borrar este personaje?", "Confirmar borrado", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int selectedrowindex = dgvCharacters.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvCharacters.Rows[selectedrowindex];
                    int selectedId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    Character selectedChar = characters.Find(u => u.ID == selectedId);

                    selectedChar.Active = 0;
                    selectedChar.Modified = DateTime.Now;
                    selectedChar.ModificationUser = Session.GetInstance().LoggedUser;
                    dbContext.SaveChanges();

                    foreach (DataGridViewRow item in dgvCharacters.SelectedRows)
                    {
                        dgvCharacters.Rows.RemoveAt(item.Index);
                    }
                    dgvCharacters.Refresh();
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dgvCharacters.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvCharacters.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvCharacters.Rows[selectedrowindex];
                int selectedId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                Character selectedChar = characters.Find(u => u.ID == selectedId);

                CharacterSheet characterSheet = new CharacterSheet(selectedChar);
            }
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            CharacterCreate characterCreate = new CharacterCreate(null, Close);
            characterCreate.Show();
        }
    }
}
