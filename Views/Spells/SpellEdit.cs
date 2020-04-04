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

namespace Views.Spells
{
    public partial class SpellEdit : Form
    {
        DndHelperContext dbContext = new DndHelperContext();
        private Action<Spell> onSuccess;
        Spell currentSpell = null;
        public SpellEdit()
        {
            InitializeComponent();
        }
        public SpellEdit(Spell spell, Action<Spell> onSuccess)
        {
            InitializeComponent();
            this.onSuccess = onSuccess;
            currentSpell = spell;
        }

        private void SpellEdit_Load(object sender, EventArgs e)
        {
            List<CharClass> classes = dbContext.Classes.OrderBy(x => x.Name).ToList();
            cbClass.DataSource = classes;
            cbClass.DisplayMember = "Name";
            cbClass.ValueMember = "ID";

            cbFamily.DataSource = Utils.GetSpellFamilies();

            tbName.Text = currentSpell.Name;
            nudLevel.Value = currentSpell.Level;
            tbCastingTime.Text = currentSpell.CastingTime;
            tbRange.Text = currentSpell.Range;
            tbDuration.Text = currentSpell.Duration;
            tbComponents.Text = currentSpell.Components;
            tbMaterials.Text = currentSpell.Materials;
            tbDescription.Text = currentSpell.Description;

            cbClass.SelectedItem = currentSpell.Class;
            cbFamily.SelectedItem = currentSpell.Family;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            currentSpell.Name = tbName.Text;
            currentSpell.CastingTime = tbCastingTime.Text;
            currentSpell.Range = tbRange.Text;
            currentSpell.Components = tbComponents.Text;
            currentSpell.Duration = tbDuration.Text;
            currentSpell.Materials = tbMaterials.Text;
            currentSpell.Description = tbDescription.Text;
            currentSpell.Family = cbFamily.SelectedItem.ToString();
            currentSpell.Level = (int)nudLevel.Value;
            currentSpell.Class = dbContext.Classes.FirstOrDefault(x => x.ID == (int)cbClass.SelectedItem);
            dbContext.SaveChanges();

            onSuccess(currentSpell);

            Close();
        }
    }
}
