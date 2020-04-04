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

namespace Views.User
{
    public partial class UserCreate : Form
    {
        DndHelperContext dbContext = new DndHelperContext();
        List<Role> roles;
        private Action<Domain.User> onSuccess;
        public UserCreate()
        {
            InitializeComponent();
        }
        public UserCreate(Action<Domain.User> onSuccess)
        {
            InitializeComponent();
            this.onSuccess = onSuccess;
        }

        private void UserCreate_Load(object sender, EventArgs e)
        {
            roles = dbContext.Roles.ToList();
            lbRoles.DataSource = roles;
            lbRoles.DisplayMember = "Name";
            lbRoles.ValueMember = "ID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            Domain.User user = dbContext.Users.Where(u => u.Username == username).FirstOrDefault<Domain.User>();
            if (user != null)
            {
                MessageBox.Show("El nombre de usuario ingresado ya esta en uso.");
                return;
            }

            string password = tbPassword.Text;
            string rePassword = tbRepeatPassword.Text;
            if(password != rePassword)
            {
                MessageBox.Show("Las contrasenas ingresadas no coinciden.");
                return;
            }

            List<Role> selectedRoles = new List<Role>();
            foreach(var item in lbRoles.SelectedItems)
            {
                selectedRoles.Add((Role)item);
            }
            //var text = (listBox1.SelectedItem as DataRowView)["columnName"].ToString();
            Domain.User newUser = new Domain.User()
            {
                Username = username,
                Password = password,
                Active = 1,
                Roles = selectedRoles,
                Created = DateTime.Now
            };
            dbContext.Users.Add(newUser);
            dbContext.SaveChanges();

            onSuccess(newUser);

            Close();
        }
    }
}
