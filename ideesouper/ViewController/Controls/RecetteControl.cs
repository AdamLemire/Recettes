using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ideesouper.ViewController;
using System.Data.OracleClient;

namespace ideesouper
{
    public partial class RecetteControl : UserControl
    {
        InterfaceBD interfaceBD = new InterfaceBD(Utilities.URL, Utilities.PORT, Utilities.SCHEMA, Utilities.USERNAME, Utilities.PASSWORD);
        public RecetteControl()
        {
            interfaceBD.ouvrirConnexion();
            InitializeComponent();
            InitializeIngredientListView();
            DefautList();
        }

        public void InitializeIngredientListView()
        {
            ingredientsListView.View = View.Details;
            ColumnHeader header1 = this.ingredientsListView.Columns.Add("Quantité", 10 * Convert.ToInt32(ingredientsListView.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header2 = this.ingredientsListView.Columns.Add("Ingrédient", 30 * Convert.ToInt32(ingredientsListView.Font.SizeInPoints), HorizontalAlignment.Left);
        }

        public void AfficheRecette(int position)
        {
            OracleDataReader recetteNomSelection = interfaceBD.envoyerRequeteSelection("SELECT NOM FROM RECETTE WHERE RECETTE_ID = '"+position+"'");
            while (recetteNomSelection.Read())
            {
                nomRecetteLabel.Text = (recetteNomSelection.GetValue(0)).ToString();
            }
            OracleDataReader recetteNombrePersonnes = interfaceBD.envoyerRequeteSelection("SELECT NB_PERSONNE FROM RECETTE WHERE RECETTE_ID = '" + position + "'");
            while (recetteNombrePersonnes.Read())
            {
                nomPersonneValeurLabel.Text = (recetteNombrePersonnes.GetValue(0)).ToString();
            }
            OracleDataReader recetteType = interfaceBD.envoyerRequeteSelection("SELECT TYPE_RECETTE FROM RECETTE WHERE RECETTE_ID = '" + position + "'");
            while (recetteType.Read())
            {
                typeRepasValeurLabel.Text = (recetteType.GetValue(0)).ToString();
            }
            OracleDataReader tempsPreparation = interfaceBD.envoyerRequeteSelection("SELECT TEMPS_PREPARATION FROM RECETTE WHERE RECETTE_ID = '" + position + "'");
            while (tempsPreparation.Read())
            {
                tempsPreparationValeurLabel.Text = (tempsPreparation.GetValue(0)).ToString();
            }
            OracleDataReader tempsCuisson = interfaceBD.envoyerRequeteSelection("SELECT TEMPS_CUISSON FROM RECETTE WHERE RECETTE_ID = '" + position + "'");
            while (tempsCuisson.Read())
            {
                tempsCuissonValeurLabel.Text = (tempsCuisson.GetValue(0)).ToString();
            }
            OracleDataReader difficulte = interfaceBD.envoyerRequeteSelection("SELECT NOM FROM DIFFICULTE WHERE DIFFICULTE_ID = (SELECT DIFFICULTE FROM RECETTE WHERE RECETTE_ID = '" + position + "')");/**/
            while (difficulte.Read())
            {
                difficulteValeurLabel.Text = (difficulte.GetValue(0)).ToString();
            }
            OracleDataReader ingredients = interfaceBD.envoyerRequeteSelection("SELECT DISTINCT INGREDIENT.NOM, RECETTE_INGREDIENT.QUANTITE FROM INGREDIENT INNER JOIN RECETTE_INGREDIENT ON INGREDIENT.INGREDIENT_ID = RECETTE_INGREDIENT.INGREDIENT_ID WHERE RECETTE_INGREDIENT.RECETTE_ID = '" + position + "'");
            ingredientsListView.Items.Clear();
            while (ingredients.Read())
            {
                string[] row1 = { ingredients.GetValue(0).ToString() };
                ingredientsListView.Items.Add(ingredients.GetValue(1).ToString()).SubItems.AddRange(row1);
            }
            OracleDataReader etapes = interfaceBD.envoyerRequeteSelection("SELECT INSTRUCTIONS FROM RECETTE WHERE RECETTE_ID = '" + position + "'");
            while (etapes.Read())
            {
                EtapeRecetteTextBox.Text = (etapes.GetValue(0)).ToString();
            }
        }

        public List<ControlDefaultText> Liste = new List<ControlDefaultText>();
        public void DefautList()
        {
            foreach (Control control in this.Controls)
            {
                Liste.Add(new ControlDefaultText(control, control.Text));
            }
        }

        public void AssignDefautList()
        {
            foreach (Control control in this.Controls)
            {
                control.Text = string.Join(",", (from cust in Liste where cust.control == control select cust.texte));
            }
            ingredientsListView.Items.Clear();
        }
    }
}
