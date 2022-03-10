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
    public partial class FormAjouterTraversee : Form
    {
        MySqlConnection maConnexion;
        public FormAjouterTraversee()
        {
            InitializeComponent();
            maConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik2022;port=3306;password=");
        }
        private void FormAjouterTraversee_Load(object sender, EventArgs e)
        {
            // Afficher les secteurs
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
             // Afficher les bateaux
            try
            {
                string requêteVoyage;
                maConnexion.Open();

                requêteVoyage = "SELECT * FROM bateau";

                var maCommande = new MySqlCommand(requêteVoyage, maConnexion);
                MySqlDataReader jeuEnr = null;
                jeuEnr = maCommande.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Bateau monBateau = new Bateau(jeuEnr.GetInt32("nobateau"), jeuEnr.GetString("nom"));
                    cmbBateau.Items.Add(monBateau);
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
            try
            {
                maConnexion.Open();
                cmbLiaison.Items.Clear();

                string requete = "SELECT l.noliaison, a.nom AS pD, d.nom AS pA FROM liaison l, port a, port d WHERE a.noport = l.noport_depart AND l.noport_arrivee = d.noport AND nosecteur = @NOSECTEUR";
                var maCommande = new MySqlCommand(requete, maConnexion);

                maCommande.Parameters.AddWithValue("@NOSECTEUR", ((Secteur)lbxSecteur.SelectedItem).GetSecteur());

                MySqlDataReader jeuEnr = maCommande.ExecuteReader();
                while (jeuEnr.Read())
                {
                    Liaison maLiaison = new Liaison(int.Parse(jeuEnr["noliaison"].ToString()), jeuEnr["pD"].ToString(), jeuEnr["pA"].ToString());
                    cmbLiaison.Items.Add(maLiaison);
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

        private void cmbLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBateau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateDepart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateArrivee_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
