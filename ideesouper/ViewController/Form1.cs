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
using ideesouper.ViewController;
using ideesouper.ViewController.Controls;

namespace ideesouper
{
    public partial class Form1 : Form
    {
        public int recetteTrouveePosition;

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
            suivanteButton.Enabled = false;
            precedenteButton.Enabled = false;
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

        private void suivanteButton_Click(object sender, EventArgs e)
        {
            recetteTrouveePosition++;
            recetteControl1.AfficheRecette(Convert.ToInt32(nouveauRepas1.idRecettesTrouvees[recetteTrouveePosition]));
            VerifierPosition();
        }

        private void precedenteButton_Click(object sender, EventArgs e)
        {
            recetteTrouveePosition--;
            recetteControl1.AfficheRecette(Convert.ToInt32(nouveauRepas1.idRecettesTrouvees[recetteTrouveePosition]));
            VerifierPosition();
        }

        public void ResetRecherche()
        {
            recetteControl1.AssignDefautList();
            Utilities.ResetAllControls(nouveauRepas1);
            nouveauRepas1.idRecettesTrouvees.Clear();
            recetteTrouveePosition = -1;
            VerifierPosition();
        }
        private void VerifierPosition()
        {
            if (recetteTrouveePosition == - 1)
            {
                suivanteButton.Enabled = false;
                precedenteButton.Enabled = false;
            }
            else if (recetteTrouveePosition == nouveauRepas1.idRecettesTrouvees.Count - 1)
            {
                suivanteButton.Enabled = false;
            }
            else
            {
                suivanteButton.Enabled = true;
            }
            if (recetteTrouveePosition > 0)
            {
                precedenteButton.Enabled = true;
            }
            else if (recetteTrouveePosition == 0)
            {
                precedenteButton.Enabled = false;
            }
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            ResetRecherche();
        }


        private void trouver_Click(object sender, EventArgs e)
        {
            nouveauRepas1.ChercheRecettes();

            if (nouveauRepas1.idRecettesTrouvees.Count > 1)
            {
                recetteControl1.AfficheRecette(Convert.ToInt32(nouveauRepas1.idRecettesTrouvees[0]));
                recetteTrouveePosition = 0;
                VerifierNavigationRecette();
            }

        }

        public void VerifierNavigationRecette()
        {
            if (nouveauRepas1.idRecettesTrouvees.Count > 1)
                suivanteButton.Enabled = true;
        }

       
    }
}
