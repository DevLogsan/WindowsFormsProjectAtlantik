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

                // Affichage des données dans les TextBox
                while(jeuEnr.Read())
                {
                    tbxSite.Text = jeuEnr["site_pb"].ToString();
                    tbxRang.Text = jeuEnr["rang_pb"].ToString();
                    tbxIdentifiant.Text = jeuEnr["identifiant_pb"].ToString();
                    tbxCle.Text = jeuEnr["clehmac_pb"].ToString();
                    cbxProduction.Checked = (bool)jeuEnr["enproduction"];
                    tbxMailSite.Text = jeuEnr["melsite"].ToString();
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
        private void gbxIdentifiant_Enter(object sender, EventArgs e)
        {

        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                maConnexion.Open();
                string requete;

                requete = "UPDATE parametres SET site_pb = @SITE_PB, rang_pb = @RANG_PB, identifiant_pb = @IDENTIFIANT_PB, clehmac_pb = @CLEHMAC_PB, enproduction = @ENPRODUCTION, melsite = @MELSITE WHERE noidentifiant = 1";
                var maModification = new MySqlCommand(requete, maConnexion);

                    maModification.Parameters.AddWithValue("@SITE_PB", tbxSite.Text);
                    maModification.Parameters.AddWithValue("@RANG_PB", tbxRang.Text);
                    maModification.Parameters.AddWithValue("@IDENTIFIANT_PB", tbxIdentifiant.Text);
                    maModification.Parameters.AddWithValue("@CLEHMAC_PB", tbxCle.Text);
                    maModification.Parameters.AddWithValue("@ENPRODUCTION", cbxProduction.Checked);
                    maModification.Parameters.AddWithValue("@MELSITE", tbxMailSite.Text);
                    maModification.ExecuteNonQuery();

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

        private void cbxProduction_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxCle_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
