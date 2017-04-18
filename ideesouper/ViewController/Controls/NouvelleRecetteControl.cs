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
            Lock();
        }

       /* private void AddIngredientClick(object sender, EventArgs e)
        {
            if (!ajoutIngredientControl1.Visible)
                ajoutIngredientControl1.Show();
            else
            {
                ajoutIngredientControl1.Hide();
                Utilities.ResetAllControls(ajoutIngredientControl1);
            }
        }
        */
        public void InitializeListView()
        {
            
            ingredientsListView.View = View.Details;
            ColumnHeader header1 = ingredientsListView.Columns.Add("Ingrédient", 50 * Convert.ToInt32(ingredientsListView.Font.SizeInPoints), HorizontalAlignment.Center);
            ColumnHeader header2 = ingredientsListView.Columns.Add("Quantité", 20 * Convert.ToInt32(ingredientsListView.Font.SizeInPoints), HorizontalAlignment.Center);
            //ColumnHeader header3 = ingredientsListView.Columns.Add("Supprimer", 10 * Convert.ToInt32(ingredientsListView.Font.SizeInPoints), HorizontalAlignment.Center);
            
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

            OracleDataReader vuesTypeIngredient =
                interfaceBD.envoyerRequeteSelection("SELECT * FROM TYPE_INGREDIENT_VIEW");
            while (vuesTypeIngredient.Read())
            {
                typeComboBox.Items.Add(vuesTypeIngredient.GetValue(0));
            }
        }


        //Rendre inutilisable bouton ajouter et le combobox ingredient
        private void Lock()
        {
            addButton.Enabled = false;
            ingredientComboBox.Enabled = false;
        }
        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ingredientComboBox.Items.Clear();
            ingredientComboBox.Enabled = true;
            
            OracleDataReader vuesIngredients =
                interfaceBD.envoyerRequeteSelection("SELECT DISTINCT NOM FROM INGREDIENT WHERE CATEGORIE ='" +
                                                    typeComboBox.Text + "' ORDER BY NOM ASC");
            while (vuesIngredients.Read())
            {
                ingredientComboBox.Items.Add(vuesIngredients.GetValue(0));
            }
        }

        //Rendre utilisable le bouton ajouter si les deux comboBox n'ont pas été rempli
        private void ingredientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addButton.Enabled = true;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantite.Text))
                return;
                ListViewItem ingredient = new ListViewItem(ingredientComboBox.Text);
                ingredient.SubItems.Add(txtQuantite.Text);
                ingredientsListView.Items.Add(ingredient);
                txtQuantite.Clear();
                Lock();
            
               


        }

     

        private void resetButton_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }


        private void buttonSuppIngredient_Click(object sender, EventArgs e)
        {
            if(ingredientsListView.Items.Count > 0 )
                ingredientsListView.SelectedItems[0].Remove();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Lock();
        }

    }
}
