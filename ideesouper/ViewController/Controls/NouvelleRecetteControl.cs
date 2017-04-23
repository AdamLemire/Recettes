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
                difficulteComboBox.Items.Add(vuesDifficulte.GetValue(0));
            }

            OracleDataReader vuesTypeRepas = interfaceBD.envoyerRequeteSelection("SELECT * FROM TYPE_REPAS_VIEW");
            while (vuesTypeRepas.Read())
            {
                typeRepasComboBox.Items.Add(vuesTypeRepas.GetValue(0));
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
            ingredientComboBox.SelectedIndex = -1;
            ingredientComboBox.Text = "";
            typeComboBox.SelectedIndex = -1;
            typeComboBox.Text = "";
            addButton.Enabled = false;
            ingredientComboBox.Enabled = false;
            
        }
        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ingredientComboBox.Items.Clear();
            ingredientComboBox.Text = "";
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
            if (string.IsNullOrEmpty(quantiteUpDown.Text))
                return;
            ListViewItem ingredient = new ListViewItem(ingredientComboBox.Text);
            ingredient.SubItems.Add(quantiteUpDown.Text);
            ingredientsListView.Items.Add(ingredient);
            quantiteUpDown.Value = 1;
            Lock();
        }



        private void resetButton_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }

        //Supprimer de la liste les ingrédients sélectionnés
        private void buttonSuppIngredient_Click(object sender, EventArgs e)
        {
            if (ingredientsListView.SelectedItems.Count > 0)
                ingredientsListView.SelectedItems[0].Remove();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Lock();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            int complet = verifyEmptyData();
            if (complet == 1)
            {
                string nom = reciepeNameTextBox.Text;
                int tempsPreparation = Convert.ToInt32(tempsPTextBox.Text);
                int tempsCuisson = Convert.ToInt32(tempsCTextBox.Text);
                string typeRecette = typeRepasComboBox.Text;
                int nbPersonne = Convert.ToInt32(nombrePersonneNumericUpDown1.Value);
                string instructions = etapeRecetteTextBox.Text;
                string difficulte = difficulteComboBox.Text;

                OracleParameter[] collection = {
                    new OracleParameter("nom", OracleType.VarChar, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, nom),
                    new OracleParameter("temps_preparation", OracleType.Number, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, tempsPreparation),
                    new OracleParameter("temps_cuisson", OracleType.Number, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, tempsCuisson),
                    new OracleParameter("type_recette", OracleType.VarChar, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, typeRecette),
                    new OracleParameter("nb_personne", OracleType.Number, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, nbPersonne),
                    new OracleParameter("instructions", OracleType.VarChar, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, instructions),
                    new OracleParameter("difficulte", OracleType.VarChar, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, difficulte),
                    new OracleParameter("recette_id", OracleType.Number, 0, System.Data.ParameterDirection.Output, null, System.Data.DataRowVersion.Default, true, 0)
                };

                //création de la recette
                interfaceBD.appelerProcedureStockee("AJOUT_RECETTE", collection);
                int idRecette = Convert.ToInt32(collection[collection.Length - 1].Value);

                foreach (ListViewItem ingredient in ingredientsListView.Items)
                {
                    string nomIngredient = ingredient.Text;
                    int quantiteIngredient = Convert.ToInt32(ingredient.SubItems[1].Text);
                    int idIngredient = Convert.ToInt32(interfaceBD.envoyerRequeteScalaire("SELECT INGREDIENT_ID FROM INGREDIENT WHERE NOM = '" + nomIngredient + "'"));

                    OracleParameter[] ingredientCollection = {
                        new OracleParameter("recette", OracleType.Number, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, idRecette),
                        new OracleParameter("ingredient", OracleType.Number, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, idIngredient),
                        new OracleParameter("qte", OracleType.Number, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, quantiteIngredient)
                    };
                    interfaceBD.appelerProcedureStockee("AJOUT_RECETTE_INGREDIENT", ingredientCollection);
                }

                string nomCorrige = nom.First().ToString().ToUpper() + String.Join("", nom.Skip(1));

                if (Convert.ToString(interfaceBD.envoyerRequeteScalaire("SELECT NOM FROM RECETTE WHERE RECETTE_ID = " + idRecette)) == nomCorrige)
                MessageBox.Show("La recette #" + idRecette + " a été créée avec succès");
                else
                MessageBox.Show("Une erreur s'est produite");
            }

            else
            {
                MessageBox.Show("Formulaire incomplet");
            }
        }

        private int verifyEmptyData()
        {
            int complet = 1;
            if (reciepeNameTextBox.Text == "" || typeRepasComboBox.SelectedIndex == -1 || tempsCTextBox.Text == "" ||
                tempsPTextBox.Text == "" || difficulteComboBox.SelectedIndex == -1 || ingredientsListView.Items.Count < 1 || etapeRecetteTextBox.Text == "")
            {
                complet = 0;
            }
            return complet;
        }
    }
}
