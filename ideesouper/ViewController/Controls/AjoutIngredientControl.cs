using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ideesouper.ViewController.Controls
{
    public partial class AjoutIngredientControl : UserControl
    {
        public AjoutIngredientControl()
        {
            InitializeComponent();
        }

        private void cancelClick(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
            Hide();
        }

    }
}
