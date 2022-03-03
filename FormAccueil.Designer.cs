﻿
namespace WindowsFormsProjectAtlantik
{
    partial class FormAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.msAccueil = new System.Windows.Forms.MenuStrip();
            this.mmAjout = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterSecteur = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterPort = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterLiaison = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterTarif = new System.Windows.Forms.ToolStripMenuItem();
            this.miBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAffichage = new System.Windows.Forms.ToolStripMenuItem();
            this.mmEdition = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifierBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.miAfficherTraversee = new System.Windows.Forms.ToolStripMenuItem();
            this.miAfficherTraverseeLiaison = new System.Windows.Forms.ToolStripMenuItem();
            this.miAfficherDetailReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifierParametres = new System.Windows.Forms.ToolStripMenuItem();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.msAccueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAccueil
            // 
            this.msAccueil.Dock = System.Windows.Forms.DockStyle.Left;
            this.msAccueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmAjout,
            this.mmEdition,
            this.mmAffichage});
            this.msAccueil.Location = new System.Drawing.Point(0, 0);
            this.msAccueil.Name = "msAccueil";
            this.msAccueil.Size = new System.Drawing.Size(126, 450);
            this.msAccueil.TabIndex = 0;
            this.msAccueil.Text = "menuStrip1";
            this.msAccueil.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msAccueil_ItemClicked);
            // 
            // mmAjout
            // 
            this.mmAjout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAjouterSecteur,
            this.miAjouterPort,
            this.miAjouterLiaison,
            this.miAjouterTarif,
            this.miBateau});
            this.mmAjout.Name = "mmAjout";
            this.mmAjout.Size = new System.Drawing.Size(113, 19);
            this.mmAjout.Text = "Ajout";
            this.mmAjout.Click += new System.EventHandler(this.mmAjout_Click);
            // 
            // miAjouterSecteur
            // 
            this.miAjouterSecteur.Name = "miAjouterSecteur";
            this.miAjouterSecteur.Size = new System.Drawing.Size(326, 22);
            this.miAjouterSecteur.Text = "Ajouter un secteur";
            this.miAjouterSecteur.Click += new System.EventHandler(this.miAjouterSecteur_Click);
            // 
            // miAjouterPort
            // 
            this.miAjouterPort.Name = "miAjouterPort";
            this.miAjouterPort.Size = new System.Drawing.Size(326, 22);
            this.miAjouterPort.Text = "Ajouter un port";
            this.miAjouterPort.Click += new System.EventHandler(this.miAjouterPort_Click);
            // 
            // miAjouterLiaison
            // 
            this.miAjouterLiaison.Name = "miAjouterLiaison";
            this.miAjouterLiaison.Size = new System.Drawing.Size(326, 22);
            this.miAjouterLiaison.Text = "Ajouter une liaison";
            this.miAjouterLiaison.Click += new System.EventHandler(this.miAjouterLiaison_Click);
            // 
            // miAjouterTarif
            // 
            this.miAjouterTarif.Name = "miAjouterTarif";
            this.miAjouterTarif.Size = new System.Drawing.Size(326, 22);
            this.miAjouterTarif.Text = "Ajouter les tarifs pour une liaison et une période";
            this.miAjouterTarif.Click += new System.EventHandler(this.miAjouterTarif_Click);
            // 
            // miBateau
            // 
            this.miBateau.Name = "miBateau";
            this.miBateau.Size = new System.Drawing.Size(326, 22);
            this.miBateau.Text = "Ajouter un bateau";
            this.miBateau.Click += new System.EventHandler(this.miBateau_Click);
            // 
            // mmAffichage
            // 
            this.mmAffichage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAfficherTraversee,
            this.miAfficherTraverseeLiaison,
            this.miAfficherDetailReservation});
            this.mmAffichage.Name = "mmAffichage";
            this.mmAffichage.Size = new System.Drawing.Size(113, 19);
            this.mmAffichage.Text = "Affichage";
            this.mmAffichage.Click += new System.EventHandler(this.mmAffichage_Click);
            // 
            // mmEdition
            // 
            this.mmEdition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miModifierBateau,
            this.miModifierParametres});
            this.mmEdition.Name = "mmEdition";
            this.mmEdition.Size = new System.Drawing.Size(113, 19);
            this.mmEdition.Text = "Edition";
            this.mmEdition.Click += new System.EventHandler(this.mmEdition_Click);
            // 
            // miModifierBateau
            // 
            this.miModifierBateau.Name = "miModifierBateau";
            this.miModifierBateau.Size = new System.Drawing.Size(236, 22);
            this.miModifierBateau.Text = "Modifier un bateau";
            this.miModifierBateau.Click += new System.EventHandler(this.miModifierBateau_Click);
            // 
            // miAfficherTraversee
            // 
            this.miAfficherTraversee.Name = "miAfficherTraversee";
            this.miAfficherTraversee.Size = new System.Drawing.Size(566, 22);
            this.miAfficherTraversee.Text = "Afficher une traversée";
            this.miAfficherTraversee.Click += new System.EventHandler(this.miAfficherTraversee_Click);
            // 
            // miAfficherTraverseeLiaison
            // 
            this.miAfficherTraverseeLiaison.Name = "miAfficherTraverseeLiaison";
            this.miAfficherTraverseeLiaison.Size = new System.Drawing.Size(566, 22);
            this.miAfficherTraverseeLiaison.Text = "Afficher les traversées pour une liaison et une date donnée avec places restantes" +
    " par catégorie";
            this.miAfficherTraverseeLiaison.Click += new System.EventHandler(this.miAfficherTraverseeLiaison_Click);
            // 
            // miAfficherDetailReservation
            // 
            this.miAfficherDetailReservation.Name = "miAfficherDetailReservation";
            this.miAfficherDetailReservation.Size = new System.Drawing.Size(566, 22);
            this.miAfficherDetailReservation.Text = "Afficher les détails d\'une réservation pour un client";
            this.miAfficherDetailReservation.Click += new System.EventHandler(this.miAfficherDetailReservation_Click);
            // 
            // miModifierParametres
            // 
            this.miModifierParametres.Name = "miModifierParametres";
            this.miModifierParametres.Size = new System.Drawing.Size(236, 22);
            this.miModifierParametres.Text = "Modifier les paramètres du site";
            this.miModifierParametres.Click += new System.EventHandler(this.miModifierParametres_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msAccueil);
            this.MainMenuStrip = this.msAccueil;
            this.Name = "FormAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.FormAccueil_Load);
            this.msAccueil.ResumeLayout(false);
            this.msAccueil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msAccueil;
        private System.Windows.Forms.ToolStripMenuItem mmAjout;
        private System.Windows.Forms.ToolStripMenuItem miAjouterSecteur;
        private System.Windows.Forms.ToolStripMenuItem miAjouterPort;
        private System.Windows.Forms.ToolStripMenuItem miAjouterLiaison;
        private System.Windows.Forms.ToolStripMenuItem miAjouterTarif;
        private System.Windows.Forms.ToolStripMenuItem miBateau;
        private System.Windows.Forms.ToolStripMenuItem mmAffichage;
        private System.Windows.Forms.ToolStripMenuItem mmEdition;
        private System.Windows.Forms.ToolStripMenuItem miModifierBateau;
        private System.Windows.Forms.ToolStripMenuItem miModifierParametres;
        private System.Windows.Forms.ToolStripMenuItem miAfficherTraversee;
        private System.Windows.Forms.ToolStripMenuItem miAfficherTraverseeLiaison;
        private System.Windows.Forms.ToolStripMenuItem miAfficherDetailReservation;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
    }
}

