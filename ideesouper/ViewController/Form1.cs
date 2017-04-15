using ideesouper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ideesouper
{
    public partial class Form1 : Form
    {
        //InterfaceBD interfaceBD = new InterfaceBD("neptune.uqtr.ca", "1521", "coursbd", "SMI1002_25", "98rghc88");

        //OracleParameter[] collection = {
        //            new OracleParameter("a", OracleType.Number, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, 3),

        //            new OracleParameter("facteur", OracleType.Number, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, 5),

        //            new OracleParameter("c", OracleType.Number, 0, System.Data.ParameterDirection.Output, null, System.Data.DataRowVersion.Default, true, 0)
        //        };

        public Form1()
        {
            //int a = 2;
            //interfaceBD.ouvrirConnexion();
            //interfaceBD.appelerProcedureStockee("multiplicateur", collection);

            InitializeComponent();
            // nouvelleRecettePanel.Hide();
            //ideePanel.Show();
            //OracleDataReader lecteur = interfaceBD.envoyerRequeteSelection("SELECT DISTINCT CATEGORIE FROM INGREDIENT");
            //while (lecteur.Read())
            //{
            //    typeIngredientComboBox1.Items.Add(lecteur.GetValue(0));
            //}

        }

        private void nouvelleRecetteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var panel in this.Controls.OfType<Panel>())
            {
                panel.Hide();
            }
            nouvelleRecettePanel.Show();
        }

        private void nouveauRepasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var panel in this.Controls.OfType<Panel>())
            {
                panel.Hide();
            }
            ideePanel.Show();

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void ideePanel_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
