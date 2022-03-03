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

                requête = "INSERT INTO port(nom) VALUES(@NOM)";
                var maCommande = new MySqlCommand(requête, maConnexion);

                maCommande.Parameters.AddWithValue("@NOM", tbxAjouterPort.Text);
                maCommande.ExecuteNonQuery();
                tbxAjouterPort.Clear();
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
