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
    public partial class UsersListControl : UserControl
    {
        List<User> users = new List<User>();

        public delegate List<User> UserListHandler();
        public event UserListHandler GetAllUsers;

        public delegate void CreateUserHandler();
        public event CreateUserHandler OnCreateUser;
        public delegate void EditUserHandler(User selectedUser);
        public event EditUserHandler OnEditUser;

        public UsersListControl(UserListHandler getAllUsers)
        {
            InitializeComponent();

            GetAllUsers = getAllUsers;
            if (GetAllUsers != null)
            {
                users = GetAllUsers();
            }

            foreach (User user in users)
            {
                AddUserToGrid(user);
            }
        }

        public void AddUserToGrid(User newUser)
        {
            List<string> roleNames = new List<string>();
            if (newUser.Roles != null)
            {
                foreach (Role role in newUser.Roles)
                {
                    roleNames.Add(role.Name);
                }
            }
            dgvUsers.Rows.Add(newUser.ID, newUser.Username, newUser.Active == 1 ? "Yes" : "No", string.Join(", ", roleNames));
        }

        public void EditUserOnGrid(User currentUser)
        {
            List<string> roleNames = new List<string>();
            if (currentUser.Roles != null)
            {
                foreach (Role role in currentUser.Roles)
                {
                    roleNames.Add(role.Name);
                }
            }
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                if (Convert.ToInt32(row.Cells["id"].Value) == currentUser.ID)
                {
                    row.Cells["username"].Value = currentUser.Username;
                    row.Cells["active"].Value = currentUser.Active == 1 ? "Si" : "No";
                    row.Cells["roles"].Value = string.Join(", ", roleNames);
                    break;
                }
            }
            dgvUsers.Refresh();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            OnCreateUser?.Invoke();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (OnEditUser != null && dgvUsers.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvUsers.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvUsers.Rows[selectedrowindex];
                int selectedId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                User selectedUser = users.Find(u => u.ID == selectedId);
                OnEditUser.Invoke(selectedUser);
            }
        }
    }
}
