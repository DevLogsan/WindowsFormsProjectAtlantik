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
    public partial class FormAjouterPort : Form
    {
        public FormAjouterPort()
        {
            InitializeComponent();
        }

        private void FormAjouterPort_Load(object sender, EventArgs e)
        {

        }

        private void lblNomPort_Click(object sender, EventArgs e)
        {

        }

        private void tbxAjouterPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouterPort_Click(object sender, EventArgs e)
        {
            MySqlConnection maConnexion;
            maConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik2022;port=3306;password=");

            try
            {
                string requête;
                maConnexion.Open(); // on se connecte

                var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");
                var résultatTest = objetRegEx.Match(tbxAjouterPort.Text);

                if (!résultatTest.Success)
                {
                    tbxAjouterPort.BackColor = Color.Red;
                    MessageBox.Show("Erreur lors de la saisie");
                }
                else
                {
                    DialogResult retour;
                    retour = MessageBox.Show("Ajouter un port ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (retour == DialogResult.Yes)
                    {
                        requête = "INSERT INTO port(nom) VALUES(@NOM)";
                        var maCommande = new MySqlCommand(requête, maConnexion);

                        maCommande.Parameters.AddWithValue("@NOM", tbxAjouterPort.Text);
                        maCommande.ExecuteNonQuery();
                        MessageBox.Show("Le port : " + tbxAjouterPort.Text + " a été ajouté.");
                        tbxAjouterPort.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Non");
                    }
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
