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
    public partial class ShortRestDialog : Form
    {
        Character character;
        Action<int> onAccept;

        public ShortRestDialog()
        {
            InitializeComponent();
        }
        public ShortRestDialog(Character character, Action<int> onAccept)
        {
            InitializeComponent();
            this.character = character;
            this.onAccept = onAccept;

            lblClassHitDice.Text = $"{character.Class.Name}: 1d{character.Class.HitDice}+{Utils.CalculateModifier(character.Constitution)}";
            lblHitDiceTotal.Text = character.Level.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int amount = (int)nudAmount.Value;
            onAccept(amount);
            Close();
        }
    }
}
