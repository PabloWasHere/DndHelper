using Controllers;
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

namespace Views.Characters
{
    public partial class CharacterCreate : Form
    {
        Action onFinish;

        DndHelperContext dbContext = new DndHelperContext();
        List<Race> races = new List<Race>();
        List<CharClass> classes = new List<CharClass>();

        Character character;
        Race chosenRace = null;
        CharClass chosenClass = null;
        AbilityBundle abilities = new AbilityBundle();

        bool updateAbilities = false;

        public CharacterCreate()
        {
            InitializeComponent();
        }
        public CharacterCreate(Character character, Action onFinish)
        {
            InitializeComponent();

            this.onFinish = onFinish;
       
            races = dbContext.Races.Where(x => x.SuperRace == null).ToList();
            lbRace.DataSource = races;
            lbRace.DisplayMember = "Name";
            lbRace.ValueMember = "ID";
            //lbRace.ClearSelected();

            classes = dbContext.Classes.ToList();
            lbClass.DataSource = classes;
            lbClass.DisplayMember = "Name";
            lbClass.ValueMember = "ID";
            //lbClass.ClearSelected();

            if (character != null)
            {
                this.character = character;
                FillFormInfo();
            }
            else
            {
                this.character = new Character();
                cbLevel.SelectedIndex = cbLevel.FindStringExact("1");
            }
        }

        private void btnRaceNext_Click(object sender, EventArgs e)
        {
            tcCharacter.SelectTab("tpClass");
        }

        private void btnClassNext_Click(object sender, EventArgs e)
        {
            tcCharacter.SelectTab("tpAbilities");
        }

        private void btnClassPrev_Click(object sender, EventArgs e)
        {
            tcCharacter.SelectTab("tpRace");
        }

        private void btnAbilitiesPrev_Click(object sender, EventArgs e)
        {
            tcCharacter.SelectTab("tpClass");
        }

        private void lbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeRace();
        }

        private void ChangeRace()
        {
            //Check if selected Race has Subraces
            Race selectedRace = (Race)lbRace.SelectedItem;
            if (selectedRace != null)
            {
                if (selectedRace.SubRaces == null || selectedRace.SubRaces.Count <= 1)
                {
                    //Save it as selected
                    chosenRace = selectedRace;
                    lbSubrace.DataSource = null;
                    lbSubrace.SelectedItem = null;
                }
                else
                {
                    //Fill the Subrace ListBox
                    List<Race> subRaces = selectedRace.SubRaces.ToList();
                    lbSubrace.DataSource = subRaces;
                    lbSubrace.DisplayMember = "Name";
                    lbSubrace.ValueMember = "ID";
                    //lbSubrace.ClearSelected();
                }

                //Display information
                FillRaceInfo(chosenRace);
                updateAbilities = true;
            }
        }

        private void lbSubrace_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSubRace();
        }

        private void ChangeSubRace()
        {
            if (lbSubrace.DataSource != null)
            {
                Race selectedRace = (Race)lbSubrace.SelectedItem;
                //Save it as selected
                chosenRace = selectedRace;
                //Display information
                FillRaceInfo(chosenRace);
                updateAbilities = true;
            }
        }

        private void FillRaceInfo(Race race)
        {
            if (race != null)
            {
                lblRaceSpeed.Text = race.Speed.ToString();
                lblRaceStrength.Text = "+" + (race.Strength + (race.SuperRace != null ? race.SuperRace.Strength : 0)).ToString();
                lblRaceDexterity.Text = "+" + (race.Dexterity + (race.SuperRace != null ? race.SuperRace.Dexterity : 0)).ToString();
                lblRaceConstitution.Text = "+" + (race.Constitution + (race.SuperRace != null ? race.SuperRace.Constitution : 0)).ToString();
                lblRaceIntelligence.Text = "+" + (race.Intelligence + (race.SuperRace != null ? race.SuperRace.Intelligence : 0)).ToString();
                lblRaceWisdom.Text = "+" + (race.Wisdom + (race.SuperRace != null ? race.SuperRace.Wisdom : 0)).ToString();
                lblRaceCharisma.Text = "+" + (race.Charisma + (race.SuperRace != null ? race.SuperRace.Charisma : 0)).ToString();
            }
        }

        private void lbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeClass();
        }

        private void ChangeClass()
        {
            CharClass selectedClass = (CharClass)lbClass.SelectedItem;
            //Save it as selected
            chosenClass = selectedClass;
            //Display information
            FillClassInfo(chosenClass);
            updateAbilities = true;
        }

        private void FillClassInfo(CharClass charClass)
        {
            if (charClass != null)
            {
                lblClassName.Text = charClass.Name;
                lblHitDice.Text = cbLevel.SelectedItem + "d" + charClass.HitDice;
            }
        }

        private void tcCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updateAbilities)
            {
                UpdateAbilitiesInfo(sender, e);
                updateAbilities = false;
            }
        }

        private void UpdateAbilitiesInfo(object sender, EventArgs e)
        {
            int strBonus = chosenRace.Strength + (chosenRace.SuperRace != null ? chosenRace.SuperRace.Strength : 0);
            int dexBonus = chosenRace.Dexterity + (chosenRace.SuperRace != null ? chosenRace.SuperRace.Dexterity : 0);
            int conBonus = chosenRace.Constitution + (chosenRace.SuperRace != null ? chosenRace.SuperRace.Constitution : 0);
            int intBonus = chosenRace.Intelligence + (chosenRace.SuperRace != null ? chosenRace.SuperRace.Intelligence : 0);
            int wisBonus = chosenRace.Wisdom + (chosenRace.SuperRace != null ? chosenRace.SuperRace.Wisdom : 0);
            int chaBonus = chosenRace.Charisma + (chosenRace.SuperRace != null ? chosenRace.SuperRace.Charisma : 0);
            int strScore = (int)nudStrength.Value + strBonus;
            int dexScore = (int)nudDexterity.Value + dexBonus;
            int conScore = (int)nudConstitution.Value + conBonus;
            int intScore = (int)nudIntelligence.Value + intBonus;
            int wisScore = (int)nudWisdom.Value + wisBonus;
            int chaScore = (int)nudCharisma.Value + chaBonus;
            lblRaBoStr.Text = strBonus.ToString();
            lblRaBoDex.Text = dexBonus.ToString();
            lblRaBoCon.Text = conBonus.ToString();
            lblRaBoInt.Text = intBonus.ToString();
            lblRaBoWis.Text = wisBonus.ToString();
            lblRaBoCha.Text = chaBonus.ToString();
            lblModStr.Text = Utils.CalculateModifier(strScore).ToString();
            lblModDex.Text = Utils.CalculateModifier(dexScore).ToString();
            lblModCon.Text = Utils.CalculateModifier(conScore).ToString();
            lblModInt.Text = Utils.CalculateModifier(intScore).ToString();
            lblModWis.Text = Utils.CalculateModifier(wisScore).ToString();
            lblModCha.Text = Utils.CalculateModifier(chaScore).ToString();
            lblTotStr.Text = strScore.ToString();
            lblTotDex.Text = dexScore.ToString();
            lblTotCon.Text = conScore.ToString();
            lblTotInt.Text = intScore.ToString();
            lblTotWis.Text = wisScore.ToString();
            lblTotCha.Text = chaScore.ToString();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            string errors = "";
            if (String.IsNullOrWhiteSpace(tbName.Text))
            {
                errors += "Necesita ingresar un nombre para su personaje";
            }
            if(chosenRace == null)
            {
                errors += "\nNecesita seleccionar una raza";
            }
            if (chosenClass == null)
            {
                errors += "\nNecesita seleccionar una clase";
            }
            if(errors != "")
            {
                MessageBox.Show(errors);
                return;
            }

            character.Name = tbName.Text;
            character.Race = chosenRace;
            character.Class = chosenClass;
            character.Level = Convert.ToInt32(cbLevel.SelectedItem);
            character.Experience = 0;
            character.MaxHp = (int)nudMaxHP.Value;
            character.CurrentHp = character.MaxHp;
            character.Speed = character.Race.Speed;
            character.Proficiency = Utils.CalculateProficiencyBonus(character.Level);
            character.ArmorClass = 10;
            character.Inspiration = false;
            character.Strength = Convert.ToInt32(lblTotStr.Text);
            character.Dexterity = Convert.ToInt32(lblTotDex.Text);
            character.Constitution = Convert.ToInt32(lblTotCon.Text);
            character.Intelligence = Convert.ToInt32(lblTotInt.Text);
            character.Wisdom = Convert.ToInt32(lblTotWis.Text);
            character.Charisma = Convert.ToInt32(lblTotCha.Text);
            character.Created = new DateTime();
            character.Active = 1;
            character.ModificationUser = Session.GetInstance().LoggedUser;
            character.Owner = Session.GetInstance().LoggedUser;

            if(character.ID == 0)
            {
                dbContext.Characters.Add(character);
            }
            dbContext.SaveChanges();

            CharacterSheet characterSheet = new CharacterSheet(character);

            onFinish?.Invoke();
            Close();
        }

        private void FillFormInfo()
        {
            if(character.Name != null)
            {
                tbName.Text = character.Name;
            }

            if(character.Race != null)
            {
                Race superRace = dbContext.Races.Where(r => r.SubRaces.Contains(character.Race)).Include(x => x.SubRaces).FirstOrDefault<Race>();
                if (superRace != null)
                {
                    lbRace.SelectedItem = superRace;
                    ChangeRace();
                    lbSubrace.SelectedItem = character.Race;
                    ChangeSubRace();
                }
                else
                {
                    lbRace.SelectedItem = character.Race;
                    ChangeRace();
                }
            }

            if(character.Class != null)
            {
                lbClass.SelectedItem = character.Class;
                ChangeClass();
                cbLevel.SelectedIndex = cbLevel.FindStringExact(character.Level != 0 ? character.Level.ToString() : "1");
                nudMaxHP.Value = character.MaxHp;
            }

            if(character.Strength > 0)
            {
                nudStrength.Value = character.Strength;
            }
            if (character.Dexterity > 0)
            {
                nudDexterity.Value = character.Dexterity;
            }
            if (character.Constitution > 0)
            {
                nudConstitution.Value = character.Constitution;
            }
            if (character.Intelligence > 0)
            {
                nudIntelligence.Value = character.Intelligence;
            }
            if (character.Wisdom > 0)
            {
                nudWisdom.Value = character.Wisdom;
            }
            if (character.Charisma > 0)
            {
                nudCharisma.Value = character.Charisma;
            }
            updateAbilities = true;
        }

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillClassInfo(chosenClass);
        }
    }
}
