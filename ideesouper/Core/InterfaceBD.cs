using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Windows.Forms;


namespace ideesouper
{
    public enum ModeVerrou { Aucun, Partage, Exclusif };
    public class InterfaceBD
    {
        private OracleConnection connexion;
        public InterfaceBD(string host, string port, string servicename, string user, string pass)
        {
            string strconn = String.Format("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})" + "(PORT={1}))(CONNECT_DATA=(SID={2})));User Id={3};Password={4};",
                  host,
                  port,
                  servicename,
                  user,
                  pass);

            connexion = new OracleConnection(strconn);
        }

        public bool ouvrirConnexion()
        {
            try
            {
                connexion.Open();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message, "Erreur lors de l'ouverture de la connexion Oracle");
                return false;
            }

            return true;
        }

        public bool fermerConnexion()
        {
            try
            {
                connexion.Close();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message, "Erreur lors de la fermeture de la connexion Oracle");
                return false;
            }
            return true;
        }

        public bool connexionEstOuverte()
        {
            if (connexion.State == System.Data.ConnectionState.Open)
                return true;

            return false;
        }

        public void CreerCommande()
        {
            OracleCommand commande = connexion.CreateCommand();
            //commande.CommandText = "INSERT INTO FRUITS (FRUITID, NOMFRUIT) VALUES (1, 'Kiwi')";
            // commande.ExecuteNonQuery();
        }

        public bool envoyerRequete(String requete)
        {
            try
            {
                OracleCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                command.ExecuteNonQuery();

                return true;
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message, "Erreur Oracle");
                return false;
            }
        }

        public bool envoyerRequete(String requete, ModeVerrou mode, String table_verrouillee)
        {
            try
            {
                OracleCommand command = connexion.CreateCommand();

                if (mode != ModeVerrou.Aucun)
                {
                    if (mode == ModeVerrou.Partage)
                        command.CommandText = "LOCK TABLE " + table_verrouillee + " IN SHARE MODE";
                    else
                        command.CommandText = "LOCK TABLE " + table_verrouillee + " IN EXCLUSIVE MODE";

                    command.ExecuteNonQuery();
                }

                command.CommandText = requete;
                command.ExecuteNonQuery();

                command.CommandText = "COMMIT";
                command.ExecuteNonQuery();

                return true;
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message, "Erreur Oracle");
                return false;
            }
        }

        public OracleDataReader envoyerRequeteSelection(String requete)
        {
            try
            {
                OracleCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                return command.ExecuteReader();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message, "Erreur Oracle");
                return null;
            }
        }

        public object envoyerRequeteScalaire(String requete)
        {
            try
            {
                OracleCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                return command.ExecuteScalar();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message, "Erreur Oracle");
                return null;
            }
        }

        public void appelerProcedureStockee(String nom, OracleParameter[] parametres)
        {
            try
            {
                OracleCommand command = connexion.CreateCommand();
                command.CommandText = nom;
                command.CommandType = System.Data.CommandType.StoredProcedure;

                if (parametres != null)
                    command.Parameters.AddRange(parametres);

                command.ExecuteNonQuery();

                return;
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message, "Erreur Oracle");
                return;
            }
        }

    }
}
