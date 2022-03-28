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
    public partial class FormAjouterSecteur : Form
    {
        public FormAjouterSecteur()
        {
            InitializeComponent();
        }
        private void FormAjouterSecteur_Load(object sender, EventArgs e)
        {
        }
        private void lblNomSecteur_Click(object sender, EventArgs e)
        {
        }
        private void tbxAjouterSecteur_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnAjouterSecteur_Click(object sender, EventArgs e)
        {
            MySqlConnection maConnexion;
            maConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik2022;port=3306;password=");

            try
            {
                string requête;
                maConnexion.Open(); // on se connecte

                var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");
                var résultatTest = objetRegEx.Match(tbxAjouterSecteur.Text);

                if (!résultatTest.Success)
                {
                    tbxAjouterSecteur.BackColor = Color.Red;
                    MessageBox.Show("Erreur lors de la saisie");
                }
                else
                {
                    tbxAjouterSecteur.BackColor = Color.White;
                    DialogResult retour;
                    retour = MessageBox.Show("Ajouter un secteur ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (retour == DialogResult.Yes)
                    {
                            requête = "INSERT INTO secteur(nom) VALUES(@NOM)";
                            var maCommande = new MySqlCommand(requête, maConnexion);

                            maCommande.Parameters.AddWithValue("@NOM", tbxAjouterSecteur.Text);
                            maCommande.ExecuteNonQuery();
                            MessageBox.Show("Le secteur : " + tbxAjouterSecteur.Text + " a été ajouté.");
                            tbxAjouterSecteur.Clear();
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
