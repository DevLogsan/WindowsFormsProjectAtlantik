using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace WindowsFormsProjectAtlantik
{
    public partial class FormAjouterTarif : Form
    {
        MySqlConnection maConnexion;
        string[] champs;
        public FormAjouterTarif()
        {
            InitializeComponent();
            maConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik2022;port=3306;password=");
        }

        private void FormAjouterTarif_Load(object sender, EventArgs e)
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
            // Affiche les périodes
            try
            {
                string requête;
                maConnexion.Open();

                requête = "SELECT * FROM periode";

                var maCommande = new MySqlCommand(requête, maConnexion);
                MySqlDataReader jeuEnr = null;
                jeuEnr = maCommande.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Periode maPeriode = new Periode(jeuEnr.GetInt32("noperiode"), jeuEnr.GetString("datedebut"), jeuEnr.GetString("datefin"));
                    cmbPeriode.Items.Add(maPeriode);
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
            // Afficher Tarif par catégorie et type
            try
            {
                string requete;
                maConnexion.Open();

                requete = "SELECT * FROM type";
                int i = 1;

                var maCommande = new MySqlCommand(requete, maConnexion);
                MySqlDataReader jeuEnr = null;
                jeuEnr = maCommande.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Tarif  monTarif = new Tarif(jeuEnr["lettrecategorie"].ToString(),int.Parse(jeuEnr["notype"].ToString()), jeuEnr["libelle"].ToString());
                    Label lbl = new Label();
                    lbl.Text = monTarif.ToString();
                    lbl.Size = new Size(150, 35);
                    lbl.Location = new Point(5, i * 35);


                    TextBox tbx = new TextBox();
                    tbx.Tag = jeuEnr["lettrecategorie"].ToString() + ";" + int.Parse(jeuEnr["notype"].ToString());
                    tbx.Location = new Point(180, i * 35);
                    gbxGroupe.Controls.Add(lbl);
                    gbxGroupe.Controls.Add(tbx);
                    i++;
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                string requete;
                maConnexion.Open();

                DialogResult retour;
                retour = MessageBox.Show("Ajouter un port ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (retour == DialogResult.Yes)
                {
                    requete = "INSERT INTO tarifer(noperiode, lettrecategorie, notype, noliaison, tarif) VALUES (@NOPERIODE, @LETTRECATEGORIE, @NOTYPE, @NOLIAISON, @TARIF)";
                    var monAjout = new MySqlCommand(requete, maConnexion);

                    var tbx = gbxGroupe.Controls.OfType<TextBox>(); //on recup tte les txb dans gbxGroup
                    foreach (TextBox text in tbx)
                    {
                        champs = (text.Tag).ToString().Split(';');
                        monAjout.Parameters.AddWithValue("@NOPERIODE", ((Periode)cmbPeriode.SelectedItem).GetNumero());
                        monAjout.Parameters.AddWithValue("@LETTRECATEGORIE", champs[0]);
                        monAjout.Parameters.AddWithValue("@NOTYPE", champs[1]);
                        monAjout.Parameters.AddWithValue("@NOLIAISON", ((Liaison)cmbLiaison.SelectedItem).GetNumero());
                        monAjout.Parameters.AddWithValue("@TARIF", text.Text);

                        monAjout.ExecuteNonQuery();
                        MessageBox.Show("Le tarif a été ajouté.");
                        monAjout.Parameters.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Non");
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
