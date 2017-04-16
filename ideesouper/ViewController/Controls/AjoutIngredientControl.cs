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
        }

        public void InitializeListsFromDatabase()
        {
            OracleDataReader vuesTypeIngredient = interfaceBD.envoyerRequeteSelection("SELECT * FROM TYPE_INGREDIENT_VIEW");
            while (vuesTypeIngredient.Read())
            {
                typeComboBox.Items.Add(vuesTypeIngredient.GetValue(0));
            }
            
        }

        private void cancelClick(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
            Hide();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ingredientComboBox.Items.Clear();
            OracleDataReader vuesIngredients = interfaceBD.envoyerRequeteSelection("SELECT DISTINCT NOM FROM INGREDIENT WHERE CATEGORIE ='" + typeComboBox.Text + "' ORDER BY NOM ASC");
            while (vuesIngredients.Read())
            {
                ingredientComboBox.Items.Add(vuesIngredients.GetValue(0));
            }
        }
    }
}
