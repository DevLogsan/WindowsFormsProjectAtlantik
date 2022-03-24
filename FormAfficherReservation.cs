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
    public partial class FormAfficherReservation : Form
    {
        MySqlConnection maConnexion;
        public FormAfficherReservation()
        {
            InitializeComponent();
            maConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik2022;port=3306;password=");
        }

        private void FormAfficherReservation_Load(object sender, EventArgs e)
        {
            try
            {
                // Affiche le nom & prénom
                string requête;
                maConnexion.Open();

                requête = "SELECT * FROM client";

                var maCommande = new MySqlCommand(requête, maConnexion);
                MySqlDataReader jeuEnr = null;
                jeuEnr = maCommande.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Client monClient = new Client(jeuEnr.GetInt32("noclient"), jeuEnr.GetString("nom"), jeuEnr.GetString("prenom"));
                    cmbNomPrenom.Items.Add(monClient);
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

        private void cmbNomPrenom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lvInformation.View = View.Details;
                lvInformation.GridLines = true;
                lvInformation.FullRowSelect = true;

                lvInformation.Columns.Add("n° de réservation", 175);
                lvInformation.Columns.Add("Liaison", 175);
                lvInformation.Columns.Add("n° de traversée", 175);
                lvInformation.Columns.Add("Date départ", 175);

                maConnexion.Open();
                lvInformation.Items.Clear();

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

        private void lvInformation_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string requete;
                maConnexion.Open();
                int i = 1;

                requete = "SELECT r.montanttotal, libelle, quantite FROM type t, enregistrer e, reservation r WHERE t.lettrecategorie = e.lettrecategorie AND t.notype = e.notype AND r.noclient = @NOCLIENT AND e.noreservation = @NORESERVATION";
                var maCommande = new MySqlCommand(requete, maConnexion);
                maCommande.Parameters.AddWithValue("@NORESERVATION", int.Parse(lvInformation.SelectedItems[0].Text));

                MySqlDataReader jeuEnr = maCommande.ExecuteReader();
                while (jeuEnr.Read())
                {
                    Reservation monType = new Reservation(jeuEnr["libelle"].ToString(), int.Parse(jeuEnr["quantite"].ToString()));
                    Label lbl = new Label();
                    lbl.Text = monType.ToString();
                    lbl.Location = new Point(5, i * 25);

                    gbxReservation.Controls.Add(lbl);
                    i++;
                }
                jeuEnr.Close();
                string requete2;

                requete2 = "SELECT montanttotal FROM reservation WHERE noreservation = @NORESERVATION";
                var maCommande2 = new MySqlCommand(requete2, maConnexion);
                maCommande2.Parameters.AddWithValue("@NORESERVATION", int.Parse(lvInformation.SelectedItems[0].Text));

                MySqlDataReader jeuEnr2 = maCommande.ExecuteReader();
                while (jeuEnr2.Read())
                {
                    Label lbl;
                    lbl = new Label();
                    lbl.Text = "Montant total : " + jeuEnr2["montanttotal"].ToString();
                    lbl.Size = new Size(300, 100);
                    lbl.Location = new Point(5, i * 25);
                    gbxReservation.Controls.Add(lbl);
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

        private void gbxReservation_Enter(object sender, EventArgs e)
        {

        }
    }
}