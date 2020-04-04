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

namespace Views.Characters
{
    public partial class CharacterSheet : Form
    {
        DndHelperContext dbContext = new DndHelperContext();
        Character character;
        public CharacterSheet()
        {
            InitializeComponent();
        }
        public CharacterSheet(Character character)
        {
            InitializeComponent();
            this.character = character;
            FillSheetInfo();
        }

        private void CharacterSheet_Load(object sender, EventArgs e)
        {

        }

        private void lblArmorClass_Click(object sender, EventArgs e)
        {

        }

        private void FillSheetInfo()
        {
            lblName.Text = character.Name;
            lblRace.Text = character.Race.Name;
            lblClass.Text = character.Class.Name;
            lblLevel.Text = "Level " + character.Level.ToString();
            lblMaxHealth.Text = character.MaxHp.ToString();
            lblCurrentHealth.Text = character.CurrentHp.ToString();
            lblProficiencyBonus.Text = "+" + Utils.CalculateProficiencyBonus(character.Level).ToString();
            lblSpeed.Text = character.Race.Speed.ToString();
            lblInitiative.Text = "+" + Utils.CalculateModifier(character.Dexterity).ToString();
            lblArmorClass.Text = character.ArmorClass.ToString();
            lblStrScore.Text = character.Strength.ToString();
            lblStrMod.Text = "+" + Utils.CalculateModifier(character.Strength).ToString();
            lblDexScore.Text = character.Dexterity.ToString();
            lblDexMod.Text = "+" + Utils.CalculateModifier(character.Dexterity).ToString();
            lblConScore.Text = character.Constitution.ToString();
            lblConMod.Text = "+" + Utils.CalculateModifier(character.Constitution).ToString();
            lblIntScore.Text = character.Intelligence.ToString();
            lblIntMod.Text = "+" + Utils.CalculateModifier(character.Intelligence).ToString();
            lblWisScore.Text = character.Wisdom.ToString();
            lblWisMod.Text = "+" + Utils.CalculateModifier(character.Wisdom).ToString();
            lblChaScore.Text = character.Charisma.ToString();
            lblChaMod.Text = "+" + Utils.CalculateModifier(character.Charisma).ToString();
            lblStrSave.Text = "+" + Utils.CalculateModifier(character.Strength).ToString();
            lblDexSave.Text = "+" + Utils.CalculateModifier(character.Dexterity).ToString();
            lblConSave.Text = "+" + Utils.CalculateModifier(character.Constitution).ToString();
            lblIntSave.Text = "+" + Utils.CalculateModifier(character.Intelligence).ToString();
            lblWisSave.Text = "+" + Utils.CalculateModifier(character.Wisdom).ToString();
            lblChaSave.Text = "+" + Utils.CalculateModifier(character.Charisma).ToString();
            lblAcroBonus.Text = "+" + Utils.CalculateModifier(character.Strength).ToString();
            lblAnimBonus.Text = "+" + Utils.CalculateModifier(character.Wisdom).ToString();
            lblArcBonus.Text = "+" + Utils.CalculateModifier(character.Intelligence).ToString();
            lblAthleBonus.Text = "+" + Utils.CalculateModifier(character.Strength).ToString();
            lblDescBonus.Text = "+" + Utils.CalculateModifier(character.Charisma).ToString();
            lblHisBonus.Text = "+" + Utils.CalculateModifier(character.Intelligence).ToString();
            lblInsiBonus.Text = "+" + Utils.CalculateModifier(character.Wisdom).ToString();
            lblIntimBonus.Text = "+" + Utils.CalculateModifier(character.Charisma).ToString();
            lblInvesBonus.Text = "+" + Utils.CalculateModifier(character.Intelligence).ToString();
            lblMedBonus.Text = "+" + Utils.CalculateModifier(character.Wisdom).ToString();
            lblNatuBonus.Text = "+" + Utils.CalculateModifier(character.Intelligence).ToString();
            lblPercBonus.Text = "+" + Utils.CalculateModifier(character.Wisdom).ToString();
            lblPerfBonus.Text = "+" + Utils.CalculateModifier(character.Charisma).ToString();
            lblPersBonus.Text = "+" + Utils.CalculateModifier(character.Charisma).ToString();
            lblReliBonus.Text = "+" + Utils.CalculateModifier(character.Intelligence).ToString();
            lblSleiBonus.Text = "+" + Utils.CalculateModifier(character.Dexterity).ToString();
            lblSteaBonus.Text = "+" + Utils.CalculateModifier(character.Dexterity).ToString();
            lblSurvBonus.Text = "+" + Utils.CalculateModifier(character.Wisdom).ToString();
        }

        private void ChangeCurrentHealth(int amount)
        {
            int newHp = character.CurrentHp + amount;
            if(newHp > character.MaxHp)
            {
                newHp = character.MaxHp;
            }
            else if(newHp < 0)
            {
                newHp = 0;
            }
            character.CurrentHp = newHp;
            dbContext.SaveChanges();

            FillSheetInfo();
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            int amount = (int)nudHealDamage.Value;
            ChangeCurrentHealth(amount);
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            int amount = (int)nudHealDamage.Value;
            ChangeCurrentHealth(-amount);
        }

        private void btnLongRest_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tomar un descanso largo recuperara tus puntos de vida perdidos", "Esta seguro que desea continuar?", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                ChangeCurrentHealth(character.MaxHp);
            }
        }

        private void btnShortRest_Click(object sender, EventArgs e)
        {
            ShortRestDialog shortRestDialog = new ShortRestDialog(character, ChangeCurrentHealth);
            shortRestDialog.ShowDialog();
        }

        private void btnLevelUp_Click(object sender, EventArgs e)
        {
            LevelUpDialog levelUpDialog = new LevelUpDialog(character, LevelUp);
            levelUpDialog.ShowDialog();
        }

        private void LevelUp(int newMaxHp)
        {
            character.MaxHp = newMaxHp;
            dbContext.SaveChanges();
            FillSheetInfo();
        }

        private void btnEditCharacter_Click(object sender, EventArgs e)
        {
            CharacterCreate characterCreate = new CharacterCreate(character, null);
            characterCreate.Show();
            Close();
        }

        private void lblStrScore_DoubleClick(object sender, EventArgs e)
        {
            OverwritePropertyDialog opd = new OverwritePropertyDialog("Fuerza", (int value) =>
                {
                    character.Strength = value;
                    character.Modified = DateTime.Now;
                    character.ModificationUser = Session.GetInstance().LoggedUser;
                    dbContext.SaveChanges();
                    FillSheetInfo();
                });
        }

        private void lblDexScore_DoubleClick(object sender, EventArgs e)
        {
            OverwritePropertyDialog opd = new OverwritePropertyDialog("Destreza", (int value) =>
            {
                character.Dexterity = value;
                character.Modified = DateTime.Now;
                character.ModificationUser = Session.GetInstance().LoggedUser;
                dbContext.SaveChanges();
                FillSheetInfo();
            });
        }

        private void lblConScore_DoubleClick(object sender, EventArgs e)
        {
            OverwritePropertyDialog opd = new OverwritePropertyDialog("Constitucion", (int value) =>
            {
                character.Constitution = value;
                character.Modified = DateTime.Now;
                character.ModificationUser = Session.GetInstance().LoggedUser;
                dbContext.SaveChanges();
                FillSheetInfo();
            });
        }

        private void lblIntScore_DoubleClick(object sender, EventArgs e)
        {
            OverwritePropertyDialog opd = new OverwritePropertyDialog("Inteligencia", (int value) =>
            {
                character.Intelligence = value;
                character.Modified = DateTime.Now;
                character.ModificationUser = Session.GetInstance().LoggedUser;
                dbContext.SaveChanges();
                FillSheetInfo();
            });
        }

        private void lblWisScore_DoubleClick(object sender, EventArgs e)
        {
            OverwritePropertyDialog opd = new OverwritePropertyDialog("Sabiduria", (int value) =>
            {
                character.Wisdom = value;
                character.Modified = DateTime.Now;
                character.ModificationUser = Session.GetInstance().LoggedUser;
                dbContext.SaveChanges();
                FillSheetInfo();
            });
        }

        private void lblChaScore_DoubleClick(object sender, EventArgs e)
        {
            OverwritePropertyDialog opd = new OverwritePropertyDialog("Carisma", (int value) =>
            {
                character.Charisma = value;
                character.Modified = DateTime.Now;
                character.ModificationUser = Session.GetInstance().LoggedUser;
                dbContext.SaveChanges();
                FillSheetInfo();
            });
        }

        private void lblMaxHealth_DoubleClick(object sender, EventArgs e)
        {
            OverwritePropertyDialog opd = new OverwritePropertyDialog("Vida maxima", (int value) =>
            {
                character.MaxHp = value;
                character.Modified = DateTime.Now;
                character.ModificationUser = Session.GetInstance().LoggedUser;
                dbContext.SaveChanges();
                FillSheetInfo();
            });
        }

        private void lblArmorClass_DoubleClick(object sender, EventArgs e)
        {
            OverwritePropertyDialog opd = new OverwritePropertyDialog("Clase de Armadura", (int value) =>
            {
                character.ArmorClass = value;
                character.Modified = DateTime.Now;
                character.ModificationUser = Session.GetInstance().LoggedUser;
                dbContext.SaveChanges();
                FillSheetInfo();
            });
        }
    }
}
