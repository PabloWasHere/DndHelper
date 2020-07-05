using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsControlLibrary
{
    public partial class HeaderMenu : UserControl
    {
        public delegate void UsersClickHandler();
        public event UsersClickHandler OnUsersClick;

        public delegate void LogoffClickHandler();
        public event LogoffClickHandler OnLogoffClick;

        public delegate void SpellsClickHandler();
        public event SpellsClickHandler OnSpellsClick;

        public HeaderMenu()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OnUsersClick?.Invoke();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            OnLogoffClick?.Invoke();
        }

        private void btnSpells_Click(object sender, EventArgs e)
        {
            OnSpellsClick?.Invoke();
        }
    }
}
