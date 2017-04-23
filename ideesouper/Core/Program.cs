using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace ideesouper
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InterfaceBD interfaceBD = new InterfaceBD("neptune.uqtr.ca", "1521", "coursbd", "SMI1002_25", "98rghc88");

            try
            {
                //interfaceBD.ouvrirConnexion();

                //interfaceBD.envoyerRequete("INSERT INTO FRUITS (FRUITID, NOMFRUIT) VALUES ('4','Jean4')", ModeVerrou.Exclusif, "FRUITS");
                //Console.Out.WriteLine(interfaceBD.envoyerRequeteScalaire("SELECT COUNT(*) FROM FRUITS").ToString() + " enregistrements dans la table fruits:");

                //OracleDataReader lecteur = interfaceBD.envoyerRequeteSelection("SELECT * FROM INGREDIENT");

                //while (lecteur.Read())
                //Console.Out.WriteLine(lecteur.GetString(0) + "");

                //lecteur.Close();


                //OracleParameter[] collection = {
                //    new OracleParameter("a", OracleType.Number, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, 3),

                //    new OracleParameter("facteur", OracleType.Number, 0, System.Data.ParameterDirection.Input, null, System.Data.DataRowVersion.Default, true, 5),

                //    new OracleParameter("c", OracleType.Number, 0, System.Data.ParameterDirection.Output, null, System.Data.DataRowVersion.Default, true, 0)
                //};

                //interfaceBD.appelerProcedureStockee("multiplicateur", collection);


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());

                //interfaceBD.fermerConnexion();

            }
            catch (Exception e)
            {
                MessageBox.Show("Une exception s'est produite: " + e.Message + " L'application va se terminer");

                if (interfaceBD.connexionEstOuverte())
                    interfaceBD.fermerConnexion();

                Application.Exit();
            }
        }
    }
}
