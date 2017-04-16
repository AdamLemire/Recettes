using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ideesouper.ViewController;
using ideesouper.ViewController.Controls;

namespace ideesouper
{
    public partial class NouvelleRecetteControl : UserControl
    {
        InterfaceBD interfaceBD = new InterfaceBD("neptune.uqtr.ca", "1521", "coursbd", "SMI1002_25", "98rghc88");
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        
        public NouvelleRecetteControl()
        {
            interfaceBD.ouvrirConnexion();
            InitializeComponent();
            InitializeListView();
            SendMessage(reciepeNameTextBox.Handle, 0x1501, 1, "Nom de la recette");
        }

        private void AddIngredientClick(object sender, EventArgs e)
        {
            if (!ajoutIngredientControl1.Visible)
                ajoutIngredientControl1.Show();
            else
            {
                ajoutIngredientControl1.Hide();
                Utilities.ResetAllControls(ajoutIngredientControl1);
            }
        }

        public void InitializeListView()
        {
            ingredientsListView.View = View.Details;
            ColumnHeader header1 = ingredientsListView.Columns.Add("Ingrédient", 50 * Convert.ToInt32(ingredientsListView.Font.SizeInPoints), HorizontalAlignment.Center);
            ColumnHeader header2 = ingredientsListView.Columns.Add("Quantité", 10 * Convert.ToInt32(ingredientsListView.Font.SizeInPoints), HorizontalAlignment.Center);
            ColumnHeader header3 = ingredientsListView.Columns.Add("Supprimer", 10 * Convert.ToInt32(ingredientsListView.Font.SizeInPoints), HorizontalAlignment.Center);

            OracleDataReader vuesDifficulte = interfaceBD.envoyerRequeteSelection("SELECT * FROM DIFFICULTE_VIEW");
            while (vuesDifficulte.Read())
            {
                comboBox2.Items.Add(vuesDifficulte.GetValue(0));
            }

            OracleDataReader vuesTypeRepas = interfaceBD.envoyerRequeteSelection("SELECT * FROM TYPE_REPAS_VIEW");
            while (vuesTypeRepas.Read())
            {
                comboBox1.Items.Add(vuesTypeRepas.GetValue(0));
            }
        }


        private void resetButton_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }

    }
}
