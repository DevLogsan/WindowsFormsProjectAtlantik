using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsProjectAtlantik
{
    public partial class FormAjouterLiaison : Form
    {
        public FormAjouterLiaison()
        {
            InitializeComponent();
        }

        private void FormAjouterLiaison_Load(object sender, EventArgs e)
        {
            MySqlConnection maConnexion;

            maConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik2022;port=3306;password=");

            // Affiche les secteurs

            try
            {
                string requête;
                maConnexion.Open();

                requête = "SELECT * FROM secteur";

                var maCommande = new MySqlCommand(requête, maConnexion);
                MySqlDataReader jeuEnr = null;
                jeuEnr = maCommande.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Secteur monSecteur = new Secteur(jeuEnr.GetInt32("nosecteur"), jeuEnr.GetString("nom"));
                    lbxSecteur.Items.Add(monSecteur);
                }

            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur " + erreur.ToString());
            }
            finally
            {
                if (maConnexion is object & maConnexion.State == ConnectionState.Open)
                {
                    maConnexion.Close();
                }

            }

            // Affiche les départs

            try
            {
                string requêteDepart;
                maConnexion.Open();

                requêteDepart = "SELECT noport_depart FROM secteur";

                var maCommande = new MySqlCommand(requêteDepart, maConnexion);
                MySqlDataReader jeuEnr = null;
                jeuEnr = maCommande.ExecuteReader();

                while (jeuEnr.Read())
                {
                    cmbDepart.Items.Add(new Port(jeuEnr["nom"].ToString()));   
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur " + erreur.ToString());
            }
            finally
            {
                if (maConnexion is object & maConnexion.State == ConnectionState.Open)
                {
                    maConnexion.Close();
                }

            }
        }

        private void lblSecteur_Click(object sender, EventArgs e)
        {

        }

        private void lbxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDepart_Click(object sender, EventArgs e)
        {

        }

        private void cmbDepart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
