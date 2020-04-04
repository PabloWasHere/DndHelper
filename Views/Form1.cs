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
using Views.Characters;
using Views.Spells;
using Views.User;

namespace Views
{
    public partial class Form1 : Form
    {
        DndHelperContext dbContext = new DndHelperContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserList userList = new UserList();
            userList.Show();
        }

        private void btnCharacters_Click(object sender, EventArgs e)
        {
            CharacterList characterList = new CharacterList();
            characterList.Show();
        }

        private void btnSpells_Click(object sender, EventArgs e)
        {
            SpellList spellList = new SpellList();
            spellList.Show();
        }
    }
}
