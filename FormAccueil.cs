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
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }
        // ----- ACCUEIL ----- //
        private void FormAccueil_Load(object sender, EventArgs e)
        {

        }
        // ----- MENU ----- //

        private void msAccueil_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        // ----- AJOUT -----
        private void mmAjout_Click(object sender, EventArgs e)
        {

        }
        // Ajouter un secteur
        private void miAjouterSecteur_Click(object sender, EventArgs e)
        {
            FormAjouterSecteur formAjouterSecteur = new FormAjouterSecteur();
            formAjouterSecteur.ShowDialog();
        }
        // Ajouter un port
        private void miAjouterPort_Click(object sender, EventArgs e)
        {
            FormAjouterPort formAjouterPort = new FormAjouterPort();
            formAjouterPort.ShowDialog();
        }
        // Ajouter une liaison
        private void miAjouterLiaison_Click(object sender, EventArgs e)
        {
            FormAjouterLiaison formAjouterLiaison = new FormAjouterLiaison();
            formAjouterLiaison.ShowDialog();
        }
        // Ajouter un tarif pour une liaison et une période
        private void miAjouterTarif_Click(object sender, EventArgs e)
        {

        }
        // Ajouter un bateau
        private void miBateau_Click(object sender, EventArgs e)
        {
            FormAjouterBateau formAjouterBateau = new FormAjouterBateau();
            formAjouterBateau.ShowDialog();
        }
        // ----- EDITION -----
        private void mmEdition_Click(object sender, EventArgs e)
        {

        }
        // Modifier un bateau
        private void miModifierBateau_Click(object sender, EventArgs e)
        {
            FormModifierBateau formModifierBateau = new FormModifierBateau();
            formModifierBateau.ShowDialog();
        }
        // Modifier les paramètres du site
        private void miModifierParametres_Click(object sender, EventArgs e)
        {

        }
        // ----- AFFICHAGE -----
        private void mmAffichage_Click(object sender, EventArgs e)
        {
            
        }
        // Afficher une traversée
        private void miAfficherTraversee_Click(object sender, EventArgs e)
        {

        }
        // Afficher les traversée pour une liaison et les places restantes par catégorie
        private void miAfficherTraverseeLiaison_Click(object sender, EventArgs e)
        {

        }
        // Afficher les détails d'une réservation
        private void miAfficherDetailReservation_Click(object sender, EventArgs e)
        {

        }
    }
}
