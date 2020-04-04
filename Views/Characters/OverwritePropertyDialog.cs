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
    public partial class OverwritePropertyDialog : Form
    {
        private Action<int> onAccept;
        public OverwritePropertyDialog()
        {
            InitializeComponent();
        }
        public OverwritePropertyDialog(string title, Action<int> onAccept)
        {
            InitializeComponent();
            lblProperty.Text = title;
            this.onAccept = onAccept;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            onAccept((int) nudPropertyValue.Value);
            Close();
        }
    }
}
