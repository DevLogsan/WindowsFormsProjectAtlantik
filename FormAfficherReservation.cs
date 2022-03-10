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
    }
}