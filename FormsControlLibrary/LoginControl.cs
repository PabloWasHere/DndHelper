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
    public partial class LoginControl : UserControl
    {
        public delegate void LoginHandler(string username, string password);
        public event LoginHandler OnLogin;

        public LoginControl()
        {
            InitializeComponent();
        }

        public LoginControl(LoginHandler onLogin)
        {
            InitializeComponent();
            OnLogin = onLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            OnLogin?.Invoke(username, password);
        }

        private void formEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                OnLogin?.Invoke(username, password);
            }
        }
    }
}
