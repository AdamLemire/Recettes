using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ideesouper.ViewController
{
    class Utilities
    {
        public static string URL = "neptune.uqtr.ca";
        public static string PORT = "1521";
        public static string SCHEMA = "coursbd";
        public static string USERNAME = "SMI1002_25";
        public static string PASSWORD = "98rghc88";


        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = -1;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }

                if (control is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)control;
                    nud.Value = 1;
                }
            }
        }

    }
}
