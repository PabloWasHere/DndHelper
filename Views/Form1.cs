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

namespace Views
{
    public partial class Form1 : Form
    {
        DndHelperContext dbContext = new DndHelperContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Character character = new Character();
            dbContext.Characters.Add(character);
            dbContext.SaveChanges();

            var characters = dbContext.Characters.ToList();
            Console.WriteLine(characters.ToString());
        }
    }
}
