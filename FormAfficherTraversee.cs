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
        Categorie[] tableauCategorie = new Categorie[100];
        public FormAfficherTraversee()
        {
            InitializeComponent();
            maConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik2022;port=3306;password=");
        }
        private int GetCapaciteMaximale(int noTraversee, string lettrecategorie)
        {
            MySqlConnection maMySQLCon = new MySqlConnection("server=localhost;user=root;database=atlantik2022;port=3306;password=");
            try
            {
                maMySQLCon.Open();
                string requete;

                requete = "SELECT sum(capacitemax)'CapaciteMax' FROM  contenir c, traversee t, bateau b where t.nobateau = b.nobateau and b.nobateau = c.nobateau and c.lettrecategorie = @LETTRECATEGORIE and t.notraversee = @NOTRAVERSEE";
                var maCommande = new MySqlCommand(requete, maMySQLCon);

                maCommande.Parameters.AddWithValue("@NOTRAVERSEE", noTraversee);
                maCommande.Parameters.AddWithValue("@LETTRECATEGORIE", lettrecategorie);
                MySqlDataReader jeuEnr = maCommande.ExecuteReader();
                jeuEnr.Read();
                if (jeuEnr["CapaciteMax"] == null)  // si c'est NULL on retourne 0
                { return 0; }
                else
                { return jeuEnr.GetInt32("CapaciteMax"); } // sinon on retourne la valeur normal
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur " + erreur.ToString());
                return -1; // on retourne une autre valeur que 0
            }
            finally
            {
                if (maMySQLCon is object & maMySQLCon.State == ConnectionState.Open)
                {
                    maMySQLCon.Close();
                }
            }
        }
        private int GetQuantiteEnregistree(int noTraversee, string lettrecategorie)
        {
            MySqlConnection maMySQLCon = new MySqlConnection("server=localhost;user=root;database=atlantik2022;port=3306;password=");
            try
            {
                string requete;
                maMySQLCon.Open();

                requete = "SELECT sum(quantite)'QuantiteEnregistree' FROM enregistrer e, traversee t, reservation r where e.noreservation = r.noreservation and r.notraversee = t.notraversee and e.lettrecategorie = @LETTRECATEGORIE and t.notraversee = @NOTRAVERSEE";
                var maCommande = new MySqlCommand(requete, maMySQLCon);

                maCommande.Parameters.AddWithValue("@NOTRAVERSEE", noTraversee);
                maCommande.Parameters.AddWithValue("@LETTRECATEGORIE", lettrecategorie);
                MySqlDataReader jeuEnr = maCommande.ExecuteReader();
                jeuEnr.Read();
                if(jeuEnr["QuantiteEnregistree"].ToString() == "")  // si c'est NULL on retourne 0
                    { return 0; }
                else
                    { return jeuEnr.GetInt32("QuantiteEnregistree"); } // sinon on retourne la valeur normal
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur " + erreur.ToString());
                return -1; // on retourne une autre valeur que 0
            }
            finally
            {
                if (maMySQLCon is object & maMySQLCon.State == ConnectionState.Open)
                {
                    maMySQLCon.Close();
                }
            }
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

            try
            {
                maConnexion.Open();
                string requete;
                requete = "SELECT * FROM categorie";
                var maCommande = new MySqlCommand(requete, maConnexion);
                MySqlDataReader jeuEnr2 = maCommande.ExecuteReader();

                lvInformation.Items.Clear();

                lvInformation.View = View.Details;
                lvInformation.GridLines = true;
                lvInformation.FullRowSelect = true;

                lvInformation.Columns.Add("n°", 30);
                lvInformation.Columns.Add("Heure", 30);
                lvInformation.Columns.Add("Bateau", 100);

                int x = 0;

                while (jeuEnr2.Read())
                {
                    Categorie maCategorie = new Categorie(jeuEnr2.GetString("lettrecategorie"), jeuEnr2.GetString("libelle"));
                    lvInformation.Columns.Add(maCategorie.GetLettreCategorie() + " " + maCategorie.GetLibelle(), 100);
                    tableauCategorie[x] = maCategorie;
                    x++;
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
                maConnexion.Open();

                string information = "SELECT t.notraversee, t.dateheuredepart, b.nom FROM traversee t, bateau b WHERE t.nobateau = b.nobateau AND noliaison = @NOLIAISON AND dateheuredepart like @DATE";
                var maCommande = new MySqlCommand(information, maConnexion);

                maCommande.Parameters.AddWithValue("@NOLIAISON", ((Liaison)cmbLiaison.SelectedItem).GetNumero());
                maCommande.Parameters.AddWithValue("@DATE", dateTraversee.Value.ToString("yyyy-MM-dd") + "%");

                MySqlDataReader jeuEnr = maCommande.ExecuteReader();
                while (jeuEnr.Read())
                {
                    var tabItem = new string[3 + tableauCategorie.Length];

                    tabItem[0] = jeuEnr["notraversee"].ToString();
                    tabItem[1] = ((DateTime)jeuEnr["dateheuredepart"]).ToString("HH:mm");
                    tabItem[2] = jeuEnr["nom"].ToString();
                    int x = 3;
                    foreach(Categorie maCategorie in tableauCategorie)
                    {
                        if(maCategorie != null)
                        {
                            int resultat = GetCapaciteMaximale(jeuEnr.GetInt32("notraversee"), maCategorie.GetLettreCategorie()) - GetQuantiteEnregistree(jeuEnr.GetInt32("notraversee"), maCategorie.GetLettreCategorie());
                            tabItem[x] = resultat.ToString();
                            x++;
                        }
                    }

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
