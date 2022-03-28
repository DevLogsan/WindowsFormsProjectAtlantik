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
    public partial class FormModifierBateau : Form
    {
        MySqlConnection maConnexion;
        public FormModifierBateau()
        {
            InitializeComponent();
            maConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik2022;port=3306;password=");
        }

        private void FormModifierBateau_Load(object sender, EventArgs e)
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

            try
            {
                string requêteVoyage;
                maConnexion.Open();

                requêteVoyage = "SELECT * FROM bateau";

                var maCommande = new MySqlCommand(requêteVoyage, maConnexion);
                MySqlDataReader jeuEnr = null;
                jeuEnr = maCommande.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Bateau monBateau = new Bateau(jeuEnr.GetInt32("nobateau"), jeuEnr.GetString("nom"));
                    cmbNomBateau.Items.Add(monBateau);
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

        private void cmbNomBateau_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var tbx = gbxGroupe.Controls.OfType<TextBox>(); //on recup tte les txb dans gbxGroup
                foreach (TextBox text in tbx)
                {
                    text.Text = string.Empty; // vide les tbx au cas ou la personne change de bateau
                }
                    maConnexion.Open();

                string modification = "SELECT capacitemax, lettrecategorie FROM contenir WHERE nobateau = @NOBATEAU";
                var maModification = new MySqlCommand(modification, maConnexion);

                maModification.Parameters.AddWithValue("@NOBATEAU", ((Bateau)cmbNomBateau.SelectedItem).GetNumero());
                
                MySqlDataReader jeuEnr = maModification.ExecuteReader();
                while (jeuEnr.Read())
                {
                    foreach (TextBox text in tbx)
                    {
                        if((string)text.Tag == jeuEnr["lettrecategorie"].ToString())
                        {
                            text.Text = jeuEnr["capacitemax"].ToString();
                            break;
                        }
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

        private void gbxGroupe_Enter(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
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
            if (vide == false)
            {
                try
                {
                    maConnexion.Open();

                    string requete;

                    requete = "UPDATE contenir SET capacitemax = @CAPACITEMAX WHERE nobateau = @NOBATEAU AND lettrecategorie = @LETTRECATEGORIE";
                    var monAjout = new MySqlCommand(requete, maConnexion);

                    foreach (TextBox text in tbx)
                    {
                        monAjout.Parameters.AddWithValue("@CAPACITEMAX", text.Text);
                        monAjout.Parameters.AddWithValue("@NOBATEAU", ((Bateau)cmbNomBateau.SelectedItem).GetNumero());
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
}
