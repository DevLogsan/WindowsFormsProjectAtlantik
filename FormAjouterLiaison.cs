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
using System.Text.RegularExpressions;

namespace WindowsFormsProjectAtlantik
{
    public partial class FormAjouterLiaison : Form
    {
        MySqlConnection maConnexion;
        public FormAjouterLiaison()
        {
            InitializeComponent();
            maConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik2022;port=3306;password=");
        }

        private void FormAjouterLiaison_Load(object sender, EventArgs e)
        {
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
                string requêteVoyage;
                maConnexion.Open();

                requêteVoyage = "SELECT * FROM port";

                var maCommande = new MySqlCommand(requêteVoyage, maConnexion);
                MySqlDataReader jeuEnr = null;
                jeuEnr = maCommande.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Port monDepart = new Port(jeuEnr.GetInt32("noport"), jeuEnr.GetString("nom"));
                    cmbDepart.Items.Add(monDepart);
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

            // Affiche les arrivées

            try
            {
                string requêteVoyage2;
                maConnexion.Open();

                requêteVoyage2 = "SELECT * FROM port";

                var maCommande2 = new MySqlCommand(requêteVoyage2, maConnexion);
                MySqlDataReader jeuEnr2 = null;
                jeuEnr2 = maCommande2.ExecuteReader();

                while (jeuEnr2.Read())
                {
                    Port monArrivee = new Port(jeuEnr2.GetInt32("noport"), jeuEnr2.GetString("nom"));
                    cmbArrivee.Items.Add(monArrivee);
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

        private void lblArriee_Click(object sender, EventArgs e)
        {

        }

        private void cmbArrivee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDistance_Click(object sender, EventArgs e)
        {

        }

        private void tbxDistance_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouterLiaison_Click(object sender, EventArgs e)
        {
            try
            {
                string requete;
                maConnexion.Open();

                requete = "INSERT INTO liaison(nosecteur, noport_depart, noport_arrivee, distance) VALUES (@NOSECTEUR, @NOPORT_DEPART, @NOPORT_ARRIVEE, @DISTANCE)";
                var monAjout = new MySqlCommand(requete, maConnexion);

                monAjout.Parameters.AddWithValue("@NOSECTEUR", ((Secteur)lbxSecteur.SelectedItem).GetSecteur());
                monAjout.Parameters.AddWithValue("@NOPORT_DEPART", ((Port)cmbDepart.SelectedItem).GetNumero());
                monAjout.Parameters.AddWithValue("@NOPORT_ARRIVEE", ((Port)cmbArrivee.SelectedItem).GetNumero());
                monAjout.Parameters.AddWithValue("@DISTANCE", tbxDistance.Text);

                monAjout.ExecuteNonQuery();
                tbxDistance.Clear();
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
    }
}