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
    public partial class FormAjouterBateau : Form
    {
        MySqlConnection maConnexion;
        long idAuthorGenere;
        public FormAjouterBateau()
        {
            InitializeComponent();
            maConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik2022;port=3306;password=");
        }

        private void FormAjouterBateau_Load(object sender, EventArgs e)
        {
            try
            {
                string requete;
                maConnexion.Open();

                requete = "SELECT * FROM categorie";
                int i = 1;

                var maCommande = new MySqlCommand(requete, maConnexion);
                MySqlDataReader jeuEnr = null;
                jeuEnr = maCommande.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Categorie maCategorie = new Categorie(jeuEnr["lettrecategorie"].ToString(), jeuEnr["libelle"].ToString());
                    Label lbl = new Label();
                    lbl.Text = maCategorie.ToString();
                    lbl.Location = new Point(5, i * 40);

                    TextBox tbx = new TextBox();
                    tbx.Tag = jeuEnr["lettrecategorie"].ToString();
                    tbx.Location = new Point(120, i * 40);
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

        private void lblNomBateau_Click(object sender, EventArgs e)
        {

        }

        private void tbxNomBateau_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbxGroupe_Enter(object sender, EventArgs e)
        {

        }
        private void btnAjouterBateau_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var vide = false;
            var tbx = gbxGroupe.Controls.OfType<TextBox>(); //on recup tte les txb dans gbxGroup
            foreach (TextBox text in tbx)
            {
                var objetRegEx = new Regex("^[0-9]*$");
                var résultatTest = objetRegEx.Match(text.Text);
                if (!résultatTest.Success)
                {
                    vide = true;
                    text.BackColor = Color.Red;
                    MessageBox.Show("Erreur lors de la saisie");
                }
                else
                {
                    text.BackColor = Color.White;
                }
            }
            if(vide == false)
            {
                try
                {
                    string requete;
                    maConnexion.Open();

                    DialogResult retour;
                    retour = MessageBox.Show("Ajouter un bateau ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (retour == DialogResult.Yes)
                    {
                        requete = "INSERT INTO bateau(nom) VALUES (@NOM)";
                        var monAjout = new MySqlCommand(requete, maConnexion);

                        monAjout.Parameters.AddWithValue("@NOM", tbxNomBateau.Text);
                        monAjout.ExecuteNonQuery();

                        idAuthorGenere = monAjout.LastInsertedId;

                        string requete2;
                        requete2 = "INSERT INTO contenir(lettrecategorie, nobateau, capacitemax) VALUES (@LETTRECATEGORIE, @NOBATEAU, @CAPACITEMAX)";
                        var monAjout2 = new MySqlCommand(requete2, maConnexion);

                        foreach (TextBox text in tbx)
                        {
                            monAjout2.Parameters.AddWithValue("@LETTRECATEGORIE", text.Tag);
                            monAjout2.Parameters.AddWithValue("@NOBATEAU", idAuthorGenere);
                            monAjout2.Parameters.AddWithValue("@CAPACITEMAX", text.Text);
                            monAjout2.ExecuteNonQuery();

                            monAjout2.Parameters.Clear();
                        }
                        MessageBox.Show("Le port : " + tbxNomBateau.Text + " a été ajouté.");
                        tbxNomBateau.Clear();
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
}
