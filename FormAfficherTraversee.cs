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
    public partial class FormAfficherTraversee : Form
    {
        MySqlConnection maConnexion;
        public FormAfficherTraversee()
        {
            InitializeComponent();
            maConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik2022;port=3306;password=");
        }
        private void FormAfficherTraversee_Load(object sender, EventArgs e)
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

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            try
            {
                lvInformation.View = View.Details;
                lvInformation.GridLines = true;
                lvInformation.FullRowSelect = true;

                lvInformation.Columns.Add("n°", 50);
                lvInformation.Columns.Add("Heure", 100);
                lvInformation.Columns.Add("Bateau", 100);
                lvInformation.Columns.Add("A Passager", 100);
                lvInformation.Columns.Add("B Véh.inf.2m", 100);
                lvInformation.Columns.Add("C Véh.sup.2m", 100);

                maConnexion.Open();
                lvInformation.Items.Clear();

                // !!! A FINIR !!!

                string information = "SELECT r.noreservation, a.nom AS portdepart, d.nom AS portarrivee, t.notraversee, t.dateheuredepart FROM client c, reservation r, traversee t, reservation e, liaison l, port a, port d WHERE c.noclient = r.noclient AND e.notraversee = t.notraversee AND t.noliaison = l.noliaison AND a.noport = l.noport_depart AND d.noport = l.noport_arrivee AND c.noclient = @NOCLIENT";
                var maCommande = new MySqlCommand(information, maConnexion);

                 maCommande.Parameters.AddWithValue("@NOCLIENT", ((Client)cmbNomPrenom.SelectedItem).GetNumeroClient());

                MySqlDataReader jeuEnr = maCommande.ExecuteReader();
                while (jeuEnr.Read())
                {
                    var tabItem = new string[5];

                    tabItem[0] = jeuEnr["noreservation"].ToString();
                    tabItem[1] = jeuEnr["portdepart"].ToString() + " - " + jeuEnr["portarrivee"].ToString();
                    tabItem[2] = jeuEnr["notraversee"].ToString();
                    tabItem[3] = jeuEnr["dateheuredepart"].ToString();

                    ListViewItem Item = new ListViewItem(tabItem);
                    lvInformation.Items.Add(Item);
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
    }
}
