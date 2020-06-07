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

namespace Views.Login
{
    public partial class Login : Form
    {
        DndHelperContext dbContext = new DndHelperContext();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            Domain.User user = dbContext.Users.Where(x => x.Username == username && x.Password == password).SingleOrDefault();
            if (user != null)
            {
                Session.GetInstance().LoggedUser = user;
                MainMenu menu = new MainMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("El usuario ingresado es incorrecto");
            }
        }
    }
}
