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
    public partial class LevelUpDialog : Form
    {
        Character character;
        Action<int> onAccept;

        public LevelUpDialog()
        {
            InitializeComponent();
        }
        public LevelUpDialog(Character character, Action<int> onAccept)
        {
            InitializeComponent();
            this.character = character;
            this.onAccept = onAccept;

            lblClass.Text = character.Class.Name;
            lblLevel.Text = (character.Level + 1).ToString();
            lblHitDice.Text = $"{character.Level + 1}d{character.Class.HitDice}";
            lblConMod.Text = Utils.CalculateModifier(character.Constitution).ToString();

            nudMaxHP.Value = character.MaxHp;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }
}
