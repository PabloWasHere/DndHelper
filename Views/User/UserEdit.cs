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
    public partial class UserEdit : Form
    {
        DndHelperContext dbContext = new DndHelperContext();
        List<Role> roles;
        private Action<Domain.User> onSuccess;
        Domain.User currentUser = null;
        public UserEdit()
        {
            InitializeComponent();
        }
        public UserEdit(Domain.User user, Action<Domain.User> onSuccess)
        {
            InitializeComponent();
            this.onSuccess = onSuccess;
            currentUser = user;
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            roles = dbContext.Roles.ToList();
            lbRoles.DataSource = roles;
            lbRoles.DisplayMember = "Name";
            lbRoles.ValueMember = "ID";
            for (int i = 0; i < lbRoles.Items.Count; i++)
            {
                Role r = (Role)lbRoles.Items[i];
                if (currentUser.Roles.Contains(r))
                {
                    lbRoles.SetSelected(i, true);
                }
            }

            tbUsername.Text = currentUser.Username;
            tbPassword.Text = currentUser.Password;
            tbRepeatPassword.Text = currentUser.Password;
            cbActive.Checked = currentUser.Active == 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            Domain.User user = dbContext.Users.Where(u => u.Username == username && u.ID != currentUser.ID).FirstOrDefault<Domain.User>();
            if (user != null)
            {
                MessageBox.Show("El nombre de usuario ingresado ya esta en uso.");
                return;
            }

            string password = tbPassword.Text;
            string rePassword = tbRepeatPassword.Text;
            if (password != rePassword)
            {
                MessageBox.Show("Las contrasenas ingresadas no coinciden.");
                return;
            }

            List<Role> selectedRoles = new List<Role>();
            foreach (var item in lbRoles.SelectedItems)
            {
                selectedRoles.Add((Role)item);
            }

            currentUser.Username = username;
            currentUser.Password = password;
            currentUser.Active = cbActive.Checked ? 1 : 0;
            currentUser.Roles = selectedRoles;
            currentUser.Modified = DateTime.Now;
            dbContext.SaveChanges();

            onSuccess(currentUser);

            Close();
        }
    }
}
