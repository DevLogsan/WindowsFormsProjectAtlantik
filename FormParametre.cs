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
    public partial class FormParametre : Form
    {
        MySqlConnection maConnexion;
        public FormParametre()
        {
            InitializeComponent();
            maConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik2022;port=3306;password=");
        }

        private void FormParametre_Load(object sender, EventArgs e)
        {
            try
            {
                string requete;
                maConnexion.Open();

                requete = "SELECT * FROM parametres";

                var maCommande = new MySqlCommand(requete, maConnexion);
                MySqlDataReader jeuEnr = null;
                jeuEnr = maCommande.ExecuteReader();

                    // Affichage "Site"
                    Label lblSite = new Label();
                    TextBox tbxSite = new TextBox();
                    lblSite.Text = "Site :";
                    lblSite.Location = new Point(5, 30);
                    tbxSite.Tag = "@SITE_PB";
                    tbxSite.Location = new Point(120, 30);
                    gbxIdentifiant.Controls.Add(lblSite);
                    gbxIdentifiant.Controls.Add(tbxSite);

                    // Affichage "Rang"
                    Label lblRang = new Label();
                    TextBox tbxRang = new TextBox();
                    lblRang.Text = "Rang :";
                    lblRang.Location = new Point(5, 60);
                    tbxRang.Tag = "@RANG_PB";
                    tbxRang.Location = new Point(120, 60);
                    gbxIdentifiant.Controls.Add(lblRang);
                    gbxIdentifiant.Controls.Add(tbxRang);

                    // Affichage "Identifiant"
                    Label lblIdentifiant = new Label();
                    TextBox tbxIdentifiant = new TextBox();
                    lblIdentifiant.Text = "Identifiant :";
                    lblIdentifiant.Location = new Point(5, 90);
                    tbxIdentifiant.Tag = "@IDENTIFIANT_PB";
                    tbxIdentifiant.Location = new Point(120, 90);
                    gbxIdentifiant.Controls.Add(lblIdentifiant);
                    gbxIdentifiant.Controls.Add(tbxIdentifiant);

                    // Affichage "Clé HMAC"
                    Label lblCle = new Label();
                    TextBox tbxCle = new TextBox();
                    lblCle.Text = "Clé HMAC :";
                    lblCle.Location = new Point(5, 120);
                    tbxCle.Tag = "@CLEHMAC_PB";
                    tbxCle.Location = new Point(120, 120);
                    gbxIdentifiant.Controls.Add(lblCle);
                    gbxIdentifiant.Controls.Add(tbxCle);
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

        private void gbxIdentifiant_Enter(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                maConnexion.Open();

                string requete;

                requete = "UPDATE contenir SET capacitemax = @CAPACITEMAX WHERE nobateau = @NOBATEAU AND lettrecategorie = @LETTRECATEGORIE";
                var monAjout = new MySqlCommand(requete, maConnexion);

                var tbx = gbxIdentifiant.Controls.OfType<TextBox>(); //on recup tte les txb dans gbxGroup
                foreach (TextBox text in tbx)
                {
                    monAjout.Parameters.AddWithValue("@CAPACITEMAX", text.Text);
                    //monAjout.Parameters.AddWithValue("@NOBATEAU", ((Bateau)cmbNomBateau.SelectedItem).GetNumero());
                    monAjout.Parameters.AddWithValue("@LETTRECATEGORIE", text.Tag);
                    monAjout.ExecuteNonQuery();

                    monAjout.Parameters.Clear();
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
