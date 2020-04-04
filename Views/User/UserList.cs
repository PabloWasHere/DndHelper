using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.User
{
    public partial class UserList : Form
    {
        DndHelperContext dbContext = new DndHelperContext();
        List<Domain.User> users = new List<Domain.User>();
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            users = dbContext.Users.Include(x => x.Roles).ToList();
            //List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach(Domain.User user in users)
            {
                //DataGridViewRow row = dgvUsers.Rows[0].Clone();
                List<string> roleNames = new List<string>();
                if (user.Roles != null)
                {
                    foreach (Role role in user.Roles)
                    {
                        roleNames.Add(role.Name);
                    }
                }
                dgvUsers.Rows.Add(user.ID, user.Username, user.Active == 1 ? "Si" : "No", string.Join(", ", roleNames));
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            UserCreate userCreateForm = new UserCreate((Domain.User newUser) =>
            {
                List<string> roleNames = new List<string>();
                if (newUser.Roles != null)
                {
                    foreach (Role role in newUser.Roles)
                    {
                        roleNames.Add(role.Name);
                    }
                }
                dgvUsers.Rows.Add(newUser.ID, newUser.Username, newUser.Active == 1 ? "Si" : "No", string.Join(", ", roleNames));
            });
            userCreateForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvUsers.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvUsers.Rows[selectedrowindex];
                int selectedId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                Domain.User selectedUser = users.Find(u => u.ID == selectedId);
                UserEdit userEditForm = new UserEdit(selectedUser, (Domain.User currentUser) =>
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
                });
                userEditForm.ShowDialog();
            }
        }
    }
}
