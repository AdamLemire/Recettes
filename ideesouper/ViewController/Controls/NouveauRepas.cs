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
    public partial class NouveauRepas : UserControl
    {
        InterfaceBD interfaceBD = new InterfaceBD("neptune.uqtr.ca", "1521", "coursbd", "SMI1002_25", "98rghc88");

        OracleParameter[] collection = {
                    new OracleParameter("a", OracleType.Number, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, 3),

                    new OracleParameter("facteur", OracleType.Number, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, 5),

                    new OracleParameter("c", OracleType.Number, 0, System.Data.ParameterDirection.Output, null, System.Data.DataRowVersion.Default, true, 0)
                };
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

        private void typeIngredientComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomIngredientComboBox1.Items.Clear();
            OracleDataReader vuesIngredients = interfaceBD.envoyerRequeteSelection("SELECT NOM FROM INGREDIENT WHERE CATEGORIE ='"+typeIngredientComboBox1.Text+"' ORDER BY NOM ASC");
            while (vuesIngredients.Read())
            {
                nomIngredientComboBox1.Items.Add(vuesIngredients.GetValue(0));
            }
        }

        private void recommencerButton_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
            lockIngredient();
        }

        private void typeRepasComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void lockIngredient()
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

    }
}

