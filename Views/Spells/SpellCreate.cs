using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Domain;

namespace Views.Spells
{
    public partial class SpellCreate : Form
    {
        DndHelperContext dbContext = new DndHelperContext();
        private Action<Spell> onSuccess;
        public SpellCreate()
        {
            InitializeComponent();
        }
        public SpellCreate(Action<Spell> onSuccess)
        {
            InitializeComponent();
            this.onSuccess = onSuccess;
        }

        private void SpellCreate_Load(object sender, EventArgs e)
        {
            List<CharClass> classes = dbContext.Classes.OrderBy(x => x.Name).ToList();
            cbClass.DataSource = classes;
            cbClass.DisplayMember = "Name";
            cbClass.ValueMember = "ID";

            cbFamily.DataSource = Utils.GetSpellFamilies();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Spell newSpell = new Spell()
            {
                Name = tbName.Text,
                CastingTime = tbCastingTime.Text,
                Range = tbRange.Text,
                Components = tbComponents.Text,
                Duration = tbDuration.Text,
                Materials = tbMaterials.Text,
                Description = tbDescription.Text,
                Family = cbFamily.SelectedItem.ToString(),
                Level = (int)nudLevel.Value,
                Custom = 1,
                Class = dbContext.Classes.FirstOrDefault(x => x.ID == (int)cbClass.SelectedItem),
                Owner = Session.GetInstance().LoggedUser
            };
            dbContext.Spells.Add(newSpell);
            dbContext.SaveChanges();

            onSuccess(newSpell);

            Close();
        }
    }
}
