using Controllers;
using Domain;
using FormsControlLibrary;
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
using Views.Spells;
using Views.User;

namespace Views
{
    public partial class MainMenu : Form
    {
        DndHelperContext dbContext = new DndHelperContext();

        LoginControl loginControl;
        UsersListControl usersListControl;
        SpellsListControl spellsListControl;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            headerPanel.Visible = false;

            usersListControl = new UsersListControl(usersListControl_GetAllUsers);
            usersListControl.OnCreateUser += usersListControl_OnCreateUser;
            usersListControl.OnEditUser += usersListControl_OnEditUser;

            spellsListControl = new SpellsListControl(spellsListControl_GetAllSpells);
            spellsListControl.OnCreateSpell += spellsListControl_OnCreateSpell;
            spellsListControl.OnEditSpell += spellsListControl_OnEditSpell;
            spellsListControl.OnDeleteSpell += spellsListControl_OnDeleteSpell;

            loginControl = new LoginControl();
            loginControl.OnLogin += loginControl_OnLogin;

            mainPanel.Controls.Add(loginControl);
            loginControl.Dock = DockStyle.Fill;
        }

        private void loginControl_OnLogin(string username, string password)
        {
            if (username != null && password != null)
            {
                Domain.User user = dbContext.Users.Where(x => x.Username == username && x.Password == password).SingleOrDefault();
                if (user != null)
                {
                    Session.GetInstance().LoggedUser = user;
                    headerPanel.Visible = true;
                    mainPanel.Controls.Clear();
                }
                else
                {
                    MessageBox.Show("El usuario ingresado es incorrecto");
                }
            }
        }

        private List<Domain.User> usersListControl_GetAllUsers()
        {
            return dbContext.Users.Include(x => x.Roles).ToList();
        }

        private void usersListControl_OnCreateUser()
        {
            UserCreate userCreateForm = new UserCreate((Domain.User newUser) =>
            {
                usersListControl.AddUserToGrid(newUser);
            });
            userCreateForm.ShowDialog();
        }

        private void usersListControl_OnEditUser(Domain.User selectedUser)
        {
            UserEdit userEditForm = new UserEdit(selectedUser, (Domain.User currentUser) =>
            {
                usersListControl.EditUserOnGrid(selectedUser);
            });
            userEditForm.ShowDialog();
        }

        private List<Spell> spellsListControl_GetAllSpells()
        {
            Domain.User loggedUser = Session.GetInstance().LoggedUser;
            return dbContext.Spells.Where(x => x.Custom == 1 && x.Owner == loggedUser).OrderBy(x => x.Level).ToList();
        }

        private void spellsListControl_OnCreateSpell()
        {
            SpellCreate spellCreateForm = new SpellCreate((Spell newSpell) =>
            {
                spellsListControl.AddSpellToGrid(newSpell);
            });
            spellCreateForm.ShowDialog();
        }

        private void spellsListControl_OnEditSpell(Spell selectedSpell)
        {
            SpellEdit spellEditForm = new SpellEdit(selectedSpell, (Spell currentSpell) =>
            {
                spellsListControl.EditSpellOnGrid(currentSpell);
            });
            spellEditForm.ShowDialog();
        }

        private void spellsListControl_OnDeleteSpell(Spell selectedSpell)
        {
            selectedSpell.Active = 0;
            selectedSpell.Modified = DateTime.Now;
            selectedSpell.ModificationUser = Session.GetInstance().LoggedUser;
            dbContext.SaveChanges();
        }

        private void headerMenu_OnLogoffClick()
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(loginControl);
            loginControl.Dock = DockStyle.Fill;

            headerPanel.Visible = false;
        }

        private void headerMenu_OnUsersClick()
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(usersListControl);
            usersListControl.Dock = DockStyle.Fill;
        }

        private void headerMenu_OnSpellsClick()
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(spellsListControl);
            spellsListControl.Dock = DockStyle.Fill;
        }
    }
}
