﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ideesouper.ViewController;

namespace ideesouper.ViewController.Controls
{
    public partial class NouveauRepas : UserControl
    {
        public List<double> idRecettesTrouvees = new List<double>();

        InterfaceBD interfaceBD = new InterfaceBD(Utilities.URL, Utilities.PORT, Utilities.SCHEMA, Utilities.USERNAME, Utilities.PASSWORD);


        public NouveauRepas()
        {
            interfaceBD.ouvrirConnexion();
            InitializeComponent();
            InitializeListsFromDatabase();
        }

        public void InitializeListsFromDatabase()
        {
            OracleDataReader vuesType = interfaceBD.envoyerRequeteSelection("SELECT * FROM TYPE_REPAS_VIEW");
            while (vuesType.Read())
            {
                typeRepasComboBox1.Items.Add(vuesType.GetValue(0));
                typeRepasComboBox2.Items.Add(vuesType.GetValue(0));
            }

            OracleDataReader vuesTempsPreparation = interfaceBD.envoyerRequeteSelection("SELECT * FROM TEMPS_PREPARATION_VIEW");
            while (vuesTempsPreparation.Read())
            {
                tempsPrepDebutComboBox.Items.Add(vuesTempsPreparation.GetValue(0));
                tempsPrepFinComboBox.Items.Add(vuesTempsPreparation.GetValue(0));
            }

            OracleDataReader vuesTempsCuisson = interfaceBD.envoyerRequeteSelection("SELECT * FROM TEMPS_CUISSON_VIEW");
            while (vuesTempsCuisson.Read())
            {
                tempsCuissonDebutComboBox.Items.Add(vuesTempsCuisson.GetValue(0));
                tempsCuissonFinComboBox.Items.Add(vuesTempsCuisson.GetValue(0));
            }

            OracleDataReader vuesDifficulte = interfaceBD.envoyerRequeteSelection("SELECT * FROM DIFFICULTE_VIEW");
            while (vuesDifficulte.Read())
            {
                difficulteComboBox.Items.Add(vuesDifficulte.GetValue(0));
            }

            OracleDataReader vuesTypeIngredient = interfaceBD.envoyerRequeteSelection("SELECT * FROM TYPE_INGREDIENT_VIEW");
            while (vuesTypeIngredient.Read())
            {
                typeIngredientComboBox1.Items.Add(vuesTypeIngredient.GetValue(0));
                typeIngredientComboBox2.Items.Add(vuesTypeIngredient.GetValue(0));
                typeIngredientComboBox3.Items.Add(vuesTypeIngredient.GetValue(0));
                typeIngredientComboBox4.Items.Add(vuesTypeIngredient.GetValue(0));
                typeIngredientComboBox5.Items.Add(vuesTypeIngredient.GetValue(0));
                typeIngredientComboBox6.Items.Add(vuesTypeIngredient.GetValue(0));
                typeIngredientComboBox7.Items.Add(vuesTypeIngredient.GetValue(0));
                typeIngredientComboBox8.Items.Add(vuesTypeIngredient.GetValue(0));
                typeIngredientComboBox9.Items.Add(vuesTypeIngredient.GetValue(0));
            }
        }


        private void typeRepas2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (typeRepas2CheckBox.Checked)
            {
                if (typeRepasComboBox1.SelectedIndex > -1)
                    typeRepasComboBox2.Enabled = true;
                else
                {
                    MessageBox.Show("Vous devez d'abord sélectionner un type dans la case précédente");
                    typeRepas2CheckBox.Checked = false;
                }
            }
            else
            {
                typeRepasComboBox2.Text = "";
                typeRepasComboBox2.Enabled = false;
            }   
        }

        private void nomIngredientComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeIngredientComboBox2.Enabled = true;
            nomIngredientComboBox2.Enabled = true;
            quantiteIngredientNumericUpDown2.Enabled = true;
        }

        private void nomIngredientComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeIngredientComboBox3.Enabled = true;
            nomIngredientComboBox3.Enabled = true;
            quantiteIngredientNumericUpDown3.Enabled = true;
        }

        private void nomIngredientComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeIngredientComboBox4.Enabled = true;
            nomIngredientComboBox4.Enabled = true;
            quantiteIngredientNumericUpDown4.Enabled = true;
        }

        private void nomIngredientComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeIngredientComboBox5.Enabled = true;
            nomIngredientComboBox5.Enabled = true;
            quantiteIngredientNumericUpDown5.Enabled = true;
        }

        private void nomIngredientComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeIngredientComboBox6.Enabled = true;
            nomIngredientComboBox6.Enabled = true;
            quantiteIngredientNumericUpDown6.Enabled = true;
        }

        private void nomIngredientComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeIngredientComboBox7.Enabled = true;
            nomIngredientComboBox7.Enabled = true;
            quantiteIngredientNumericUpDown7.Enabled = true;
        }

        private void nomIngredientComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeIngredientComboBox8.Enabled = true;
            nomIngredientComboBox8.Enabled = true;
            quantiteIngredientNumericUpDown8.Enabled = true;
        }

        private void nomIngredientComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeIngredientComboBox9.Enabled = true;
            nomIngredientComboBox9.Enabled = true;
            quantiteIngredientNumericUpDown9.Enabled = true;
        }

        private void LockIngredient()
        {
            typeIngredientComboBox2.Enabled = false;
            typeIngredientComboBox3.Enabled = false;
            typeIngredientComboBox4.Enabled = false;
            typeIngredientComboBox5.Enabled = false;
            typeIngredientComboBox6.Enabled = false;
            typeIngredientComboBox7.Enabled = false;
            typeIngredientComboBox8.Enabled = false;
            typeIngredientComboBox9.Enabled = false;
            nomIngredientComboBox2.Enabled = false;
            nomIngredientComboBox3.Enabled = false;
            nomIngredientComboBox4.Enabled = false;
            nomIngredientComboBox5.Enabled = false;
            nomIngredientComboBox6.Enabled = false;
            nomIngredientComboBox7.Enabled = false;
            nomIngredientComboBox8.Enabled = false;
            nomIngredientComboBox9.Enabled = false;
            quantiteIngredientNumericUpDown2.Enabled = false;
            quantiteIngredientNumericUpDown3.Enabled = false;
            quantiteIngredientNumericUpDown4.Enabled = false;
            quantiteIngredientNumericUpDown5.Enabled = false;
            quantiteIngredientNumericUpDown6.Enabled = false;
            quantiteIngredientNumericUpDown7.Enabled = false;
            quantiteIngredientNumericUpDown8.Enabled = false;
            quantiteIngredientNumericUpDown9.Enabled = false;
        }

        //partie de la recherche concernant les ingrédients. Impossible de faire une fonction avec cette recherche car le nombre d'ingrédients à rechercher est variable
        public string getIngredients()
        {
            string ingredientsRecherche = "";
            int nbCombobox = 0;
            if (nomIngredientComboBox1.Text != "")
            {
                ingredientsRecherche = " INTERSECT " +
                "(SELECT RECETTE_INGREDIENT.RECETTE_ID FROM RECETTE_INGREDIENT INNER JOIN INGREDIENT ON RECETTE_INGREDIENT.INGREDIENT_ID = INGREDIENT.INGREDIENT_ID WHERE INGREDIENT.NOM = '" +
                nomIngredientComboBox1.Text + "'";
                nbCombobox++;
                if (nomIngredientComboBox2.Text != "")
                {
                    ingredientsRecherche += " OR INGREDIENT.NOM = '" + nomIngredientComboBox2.Text + "'";
                    nbCombobox++;
                }

                if (nomIngredientComboBox3.Text != "")
                {
                    ingredientsRecherche += " OR INGREDIENT.NOM = '" + nomIngredientComboBox3.Text + "'";
                    nbCombobox++;
                }
                if (nomIngredientComboBox4.Text != "")
                {
                    ingredientsRecherche += " OR INGREDIENT.NOM = '" + nomIngredientComboBox4.Text + "'";
                    nbCombobox++;
                }
                if (nomIngredientComboBox5.Text != "")
                {
                    ingredientsRecherche += " OR INGREDIENT.NOM = '" + nomIngredientComboBox5.Text + "'";
                    nbCombobox++;
                }
                if (nomIngredientComboBox6.Text != "")
                {
                    ingredientsRecherche += " OR INGREDIENT.NOM = '" + nomIngredientComboBox6.Text + "'";
                    nbCombobox++;
                }
                if (nomIngredientComboBox7.Text != "")
                {
                    ingredientsRecherche += " OR INGREDIENT.NOM = '" + nomIngredientComboBox7.Text + "'";
                    nbCombobox++;
                }
                if (nomIngredientComboBox8.Text != "")
                {
                    ingredientsRecherche += " OR INGREDIENT.NOM = '" + nomIngredientComboBox8.Text + "'";
                    nbCombobox++;
                }
                if (nomIngredientComboBox9.Text != "")
                {
                    ingredientsRecherche += " OR INGREDIENT.NOM = '" + nomIngredientComboBox9.Text + "'";
                    nbCombobox++;
                }
                ingredientsRecherche += " GROUP BY RECETTE_ID HAVING COUNT(DISTINCT RECETTE_INGREDIENT.INGREDIENT_ID) = " + nbCombobox + ")";
            }
            return ingredientsRecherche;
        }

        //Méthode de la recherche de recette en fonction de tous les paramètres entrés
        public void ChercheRecettes()
        {
            valeurDefautRecherche();
            idRecettesTrouvees.Clear();

            int tempsCuissonMin = Convert.ToInt32(tempsCuissonDebutComboBox.Text);
            int tempsCuissonMax = Convert.ToInt32(tempsCuissonFinComboBox.Text);
            int tempsPreparationMin = Convert.ToInt32(tempsPrepDebutComboBox.Text);
            int tempsPreparationMax = Convert.ToInt32(tempsPrepFinComboBox.Text);
            string typeRepas = "'"+typeRepasComboBox1.Text+"'";

            string inputsRecherche = tempsCuissonMin + "," + tempsCuissonMax + "," + tempsPreparationMin + "," +
                                     tempsPreparationMax + "," + typeRepas;

            OracleDataReader rechercheRecette =
                interfaceBD.envoyerRequeteSelection("(SELECT * FROM TABLE(RECHERCHE_RECETTE_FCT("+inputsRecherche+")))"+getIngredients());

            while (rechercheRecette.Read())
            {
                idRecettesTrouvees.Add(rechercheRecette.GetDouble(0));
            }           
        }

        private void typeIngredientComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomIngredientComboBox1.Items.Clear();
            OracleDataReader vuesIngredients = interfaceBD.envoyerRequeteSelection("SELECT DISTINCT NOM FROM INGREDIENT WHERE CATEGORIE ='" + typeIngredientComboBox1.Text + "' ORDER BY NOM ASC");
            while (vuesIngredients.Read())
            {
                nomIngredientComboBox1.Items.Add(vuesIngredients.GetValue(0));
            }
        }

        private void typeIngredientComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomIngredientComboBox2.Items.Clear();
            OracleDataReader vuesIngredients = interfaceBD.envoyerRequeteSelection("SELECT DISTINCT NOM FROM INGREDIENT WHERE CATEGORIE ='" + typeIngredientComboBox2.Text + "' ORDER BY NOM ASC");
            while (vuesIngredients.Read())
            {
                nomIngredientComboBox2.Items.Add(vuesIngredients.GetValue(0));
            }
        }

        private void typeIngredientComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomIngredientComboBox3.Items.Clear();
            OracleDataReader vuesIngredients = interfaceBD.envoyerRequeteSelection("SELECT DISTINCT NOM FROM INGREDIENT WHERE CATEGORIE ='" + typeIngredientComboBox3.Text + "' ORDER BY NOM ASC");
            while (vuesIngredients.Read())
            {
                nomIngredientComboBox3.Items.Add(vuesIngredients.GetValue(0));
            }
        }

        private void typeIngredientComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomIngredientComboBox4.Items.Clear();
            OracleDataReader vuesIngredients = interfaceBD.envoyerRequeteSelection("SELECT DISTINCT NOM FROM INGREDIENT WHERE CATEGORIE ='" + typeIngredientComboBox4.Text + "' ORDER BY NOM ASC");
            while (vuesIngredients.Read())
            {
                nomIngredientComboBox4.Items.Add(vuesIngredients.GetValue(0));
            }
        }

        private void typeIngredientComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomIngredientComboBox5.Items.Clear();
            OracleDataReader vuesIngredients = interfaceBD.envoyerRequeteSelection("SELECT NOM DISTINCT FROM INGREDIENT WHERE CATEGORIE ='" + typeIngredientComboBox5.Text + "' ORDER BY NOM ASC");
            while (vuesIngredients.Read())
            {
                nomIngredientComboBox5.Items.Add(vuesIngredients.GetValue(0));
            }
        }

        private void typeIngredientComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomIngredientComboBox6.Items.Clear();
            OracleDataReader vuesIngredients = interfaceBD.envoyerRequeteSelection("SELECT NOM DISTINCT FROM INGREDIENT WHERE CATEGORIE ='" + typeIngredientComboBox6.Text + "' ORDER BY NOM ASC");
            while (vuesIngredients.Read())
            {
                nomIngredientComboBox6.Items.Add(vuesIngredients.GetValue(0));
            }
        }

        private void typeIngredientComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomIngredientComboBox7.Items.Clear();
            OracleDataReader vuesIngredients = interfaceBD.envoyerRequeteSelection("SELECT NOM DISTINCT FROM INGREDIENT WHERE CATEGORIE ='" + typeIngredientComboBox7.Text + "' ORDER BY NOM ASC");
            while (vuesIngredients.Read())
            {
                nomIngredientComboBox7.Items.Add(vuesIngredients.GetValue(0));
            }
        }

        private void typeIngredientComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomIngredientComboBox8.Items.Clear();
            OracleDataReader vuesIngredients = interfaceBD.envoyerRequeteSelection("SELECT NOM DISTINCT FROM INGREDIENT WHERE CATEGORIE ='" + typeIngredientComboBox8.Text + "' ORDER BY NOM ASC");
            while (vuesIngredients.Read())
            {
                nomIngredientComboBox8.Items.Add(vuesIngredients.GetValue(0));
            }
        }

        private void typeIngredientComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomIngredientComboBox9.Items.Clear();
            OracleDataReader vuesIngredients = interfaceBD.envoyerRequeteSelection("SELECT NOM DISTINCT FROM INGREDIENT WHERE CATEGORIE ='" + typeIngredientComboBox9.Text + "' ORDER BY NOM ASC");
            while (vuesIngredients.Read())
            {
                nomIngredientComboBox9.Items.Add(vuesIngredients.GetValue(0));
            }
        }

        private void valeurDefautRecherche()
        {
            foreach (Control control in this.Controls)
            {
                if (control is ComboBox && (control.Name == "tempsCuissonDebutComboBox" || control.Name == "tempsPrepDebutComboBox" ||
                    control.Name == "typeRepasComboBox1") )

                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.SelectedIndex == -1)
                    {
                        comboBox.SelectedIndex = 0;
                    }
                }
                else if (control is ComboBox && (control.Name == "tempsCuissonFinComboBox" ||
                         control.Name == "tempsPrepFinComboBox"))
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.SelectedIndex == -1)
                    {
                        comboBox.SelectedIndex = comboBox.Items.Count - 1;
                    }
                }
            }
            
        }
    }
}

