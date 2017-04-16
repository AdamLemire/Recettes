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

namespace ideesouper.ViewController.Controls
{
    public partial class AjoutIngredientControl : UserControl
    {
        InterfaceBD interfaceBD = new InterfaceBD("neptune.uqtr.ca", "1521", "coursbd", "SMI1002_25", "98rghc88");

        public AjoutIngredientControl()
        {
            interfaceBD.ouvrirConnexion();
            InitializeComponent();
            InitializeListsFromDatabase();
            Lock();
        }


        public void InitializeListsFromDatabase()
        {
            OracleDataReader vuesTypeIngredient =
                interfaceBD.envoyerRequeteSelection("SELECT * FROM TYPE_INGREDIENT_VIEW");
            while (vuesTypeIngredient.Read())
            {
                typeComboBox.Items.Add(vuesTypeIngredient.GetValue(0));
            }
        }




        private void cancelClick(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
            Lock();
            Hide();
        }


        //Rendre inutilisable bouton ajouter et le combobox ingredient
        private void Lock()
        {
            addButton.Enabled = false;
            ingredientComboBox.Enabled = false;
        }

        //SelectionChangeCommitted	 Se produit quand l'utilisateur change l'élément sélectionné et quand cette modification est affichée dans ComboBox.
        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ingredientComboBox.Enabled = true;
            ingredientComboBox.Items.Clear();
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
            string TypeIngredient = typeComboBox.SelectedItem.ToString();
            string NomIngredient = ingredientComboBox.SelectedItem.ToString();
            ListViewItem ingredient = new ListViewItem(NomIngredient);
            ingredient.SubItems.Add(TypeIngredient);
            //MessageBox.Show(typeComboBox.SelectedItem.ToString());
            

        }
    }
}
