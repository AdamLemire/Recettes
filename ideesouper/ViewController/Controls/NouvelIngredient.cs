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

namespace ideesouper.ViewController.Controls
{
    public partial class NouvelIngredient : UserControl
    {
        InterfaceBD interfaceBD = new InterfaceBD("neptune.uqtr.ca", "1521", "coursbd", "SMI1002_25", "98rghc88");
        public NouvelIngredient()
        {
            interfaceBD.ouvrirConnexion();
            InitializeComponent();
            InitializeListView();
            Lock();
        }

        public void InitializeListView()
        {
            OracleDataReader vuesTypeIngredient =
                interfaceBD.envoyerRequeteSelection("SELECT * FROM TYPE_INGREDIENT_VIEW");
            while (vuesTypeIngredient.Read())
            {
                categorieComboBox.Items.Add(vuesTypeIngredient.GetValue(0));
            }
        }

        private void Lock()
        {
            ajouterBouton.Enabled = false;
            ingredientTexteBox.Enabled = false;
        }


        private void AnnulerBouton_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
            Lock();
        }

        private void categorieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ingredientTexteBox.Enabled = true;
            ingredientTexteBox.Clear();
        }

        private void ingrédientTexteBox_TextChanged(object sender, EventArgs e)
        {
            ajouterBouton.Enabled = true;
        }

        private void ajouterBouton_Click(object sender, EventArgs e)
        {
            string nom = ingredientTexteBox.Text;
            string categorie = categorieComboBox.Text;

            int complet = verifyEmptyData();
            if (complet == 1)
            {
                OracleParameter[] collection = {
                    new OracleParameter("nom", OracleType.VarChar, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, nom),
                    new OracleParameter("categorie", OracleType.VarChar, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, categorie),
                    new OracleParameter("ingredient_id", OracleType.Number, 0, System.Data.ParameterDirection.Output, null, System.Data.DataRowVersion.Default, true, 0)
                };


                //MessageBox.Show("La recette #" + idRecette + " a été créée avec succès");
            }
            else
            {
                MessageBox.Show("Formulaire incomplet");
            }
                


            Lock();
        }





        //Verifier que le nom et la categorie de l'ingredient n'est pas vide
        private int verifyEmptyData()
        {
            int complet = 1;
            if (ingredientTexteBox.Text == "" || categorieComboBox.SelectedIndex == -1 )
            {
                complet = 0;
            }
            return complet;
        }
    }
}
