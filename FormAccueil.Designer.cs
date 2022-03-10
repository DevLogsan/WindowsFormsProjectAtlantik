
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
            this.components = new System.ComponentModel.Container();
            this.msAccueil = new System.Windows.Forms.MenuStrip();
            this.mmAjout = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterSecteur = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterPort = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterLiaison = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterTarif = new System.Windows.Forms.ToolStripMenuItem();
            this.mmEdition = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifierBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifierParametres = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAffichage = new System.Windows.Forms.ToolStripMenuItem();
            this.miAfficherTraversee = new System.Windows.Forms.ToolStripMenuItem();
            this.miAfficherTraverseeLiaison = new System.Windows.Forms.ToolStripMenuItem();
            this.miAfficherDetailReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MiAjouterTraversee = new System.Windows.Forms.ToolStripMenuItem();
            this.msAccueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAccueil
            // 
            this.msAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.msAccueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmAjout,
            this.mmEdition,
            this.mmAffichage});
            this.msAccueil.Location = new System.Drawing.Point(0, 0);
            this.msAccueil.Name = "msAccueil";
            this.msAccueil.Padding = new System.Windows.Forms.Padding(7, 1, 0, 1);
            this.msAccueil.Size = new System.Drawing.Size(592, 24);
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
            this.miAjouterBateau,
            this.MiAjouterTraversee,
            this.miAjouterTarif});
            this.mmAjout.ForeColor = System.Drawing.Color.White;
            this.mmAjout.Name = "mmAjout";
            this.mmAjout.Size = new System.Drawing.Size(48, 22);
            this.mmAjout.Text = "Ajout";
            this.mmAjout.Click += new System.EventHandler(this.mmAjout_Click);
            // 
            // miAjouterSecteur
            // 
            this.miAjouterSecteur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.miAjouterSecteur.ForeColor = System.Drawing.Color.White;
            this.miAjouterSecteur.Name = "miAjouterSecteur";
            this.miAjouterSecteur.Size = new System.Drawing.Size(326, 22);
            this.miAjouterSecteur.Text = "Ajouter un secteur";
            this.miAjouterSecteur.Click += new System.EventHandler(this.miAjouterSecteur_Click);
            // 
            // miAjouterPort
            // 
            this.miAjouterPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.miAjouterPort.ForeColor = System.Drawing.Color.White;
            this.miAjouterPort.Name = "miAjouterPort";
            this.miAjouterPort.Size = new System.Drawing.Size(326, 22);
            this.miAjouterPort.Text = "Ajouter un port";
            this.miAjouterPort.Click += new System.EventHandler(this.miAjouterPort_Click);
            // 
            // miAjouterLiaison
            // 
            this.miAjouterLiaison.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.miAjouterLiaison.ForeColor = System.Drawing.Color.White;
            this.miAjouterLiaison.Name = "miAjouterLiaison";
            this.miAjouterLiaison.Size = new System.Drawing.Size(326, 22);
            this.miAjouterLiaison.Text = "Ajouter une liaison";
            this.miAjouterLiaison.Click += new System.EventHandler(this.miAjouterLiaison_Click);
            // 
            // miAjouterBateau
            // 
            this.miAjouterBateau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.miAjouterBateau.ForeColor = System.Drawing.Color.White;
            this.miAjouterBateau.Name = "miAjouterBateau";
            this.miAjouterBateau.Size = new System.Drawing.Size(326, 22);
            this.miAjouterBateau.Text = "Ajouter un bateau";
            this.miAjouterBateau.Click += new System.EventHandler(this.miAjouterBateau_Click);
            // 
            // miAjouterTarif
            // 
            this.miAjouterTarif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.miAjouterTarif.ForeColor = System.Drawing.Color.White;
            this.miAjouterTarif.Name = "miAjouterTarif";
            this.miAjouterTarif.Size = new System.Drawing.Size(326, 22);
            this.miAjouterTarif.Text = "Ajouter les tarifs pour une liaison et une période";
            this.miAjouterTarif.Click += new System.EventHandler(this.miAjouterTarif_Click);
            // 
            // mmEdition
            // 
            this.mmEdition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miModifierBateau,
            this.miModifierParametres});
            this.mmEdition.ForeColor = System.Drawing.Color.White;
            this.mmEdition.Name = "mmEdition";
            this.mmEdition.Size = new System.Drawing.Size(56, 22);
            this.mmEdition.Text = "Edition";
            this.mmEdition.Click += new System.EventHandler(this.mmEdition_Click);
            // 
            // miModifierBateau
            // 
            this.miModifierBateau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.miModifierBateau.ForeColor = System.Drawing.Color.White;
            this.miModifierBateau.Name = "miModifierBateau";
            this.miModifierBateau.Size = new System.Drawing.Size(236, 22);
            this.miModifierBateau.Text = "Modifier un bateau";
            this.miModifierBateau.Click += new System.EventHandler(this.miModifierBateau_Click);
            // 
            // miModifierParametres
            // 
            this.miModifierParametres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.miModifierParametres.ForeColor = System.Drawing.Color.White;
            this.miModifierParametres.Name = "miModifierParametres";
            this.miModifierParametres.Size = new System.Drawing.Size(236, 22);
            this.miModifierParametres.Text = "Modifier les paramètres du site";
            this.miModifierParametres.Click += new System.EventHandler(this.miModifierParametres_Click);
            // 
            // mmAffichage
            // 
            this.mmAffichage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.mmAffichage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAfficherTraversee,
            this.miAfficherTraverseeLiaison,
            this.miAfficherDetailReservation});
            this.mmAffichage.ForeColor = System.Drawing.Color.White;
            this.mmAffichage.Name = "mmAffichage";
            this.mmAffichage.Size = new System.Drawing.Size(70, 22);
            this.mmAffichage.Text = "Affichage";
            this.mmAffichage.Click += new System.EventHandler(this.mmAffichage_Click);
            // 
            // miAfficherTraversee
            // 
            this.miAfficherTraversee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.miAfficherTraversee.ForeColor = System.Drawing.Color.White;
            this.miAfficherTraversee.Name = "miAfficherTraversee";
            this.miAfficherTraversee.Size = new System.Drawing.Size(566, 22);
            this.miAfficherTraversee.Text = "Afficher une traversée";
            this.miAfficherTraversee.Click += new System.EventHandler(this.miAfficherTraversee_Click);
            // 
            // miAfficherTraverseeLiaison
            // 
            this.miAfficherTraverseeLiaison.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.miAfficherTraverseeLiaison.ForeColor = System.Drawing.Color.White;
            this.miAfficherTraverseeLiaison.Name = "miAfficherTraverseeLiaison";
            this.miAfficherTraverseeLiaison.Size = new System.Drawing.Size(566, 22);
            this.miAfficherTraverseeLiaison.Text = "Afficher les traversées pour une liaison et une date donnée avec places restantes" +
    " par catégorie";
            this.miAfficherTraverseeLiaison.Click += new System.EventHandler(this.miAfficherTraverseeLiaison_Click);
            // 
            // miAfficherDetailReservation
            // 
            this.miAfficherDetailReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.miAfficherDetailReservation.ForeColor = System.Drawing.Color.White;
            this.miAfficherDetailReservation.Name = "miAfficherDetailReservation";
            this.miAfficherDetailReservation.Size = new System.Drawing.Size(566, 22);
            this.miAfficherDetailReservation.Text = "Afficher les détails d\'une réservation pour un client";
            this.miAfficherDetailReservation.Click += new System.EventHandler(this.miAfficherDetailReservation_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MiAjouterTraversee
            // 
            this.MiAjouterTraversee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.MiAjouterTraversee.ForeColor = System.Drawing.Color.White;
            this.MiAjouterTraversee.Name = "MiAjouterTraversee";
            this.MiAjouterTraversee.Size = new System.Drawing.Size(326, 22);
            this.MiAjouterTraversee.Text = "Ajouter une traversée";
            this.MiAjouterTraversee.Click += new System.EventHandler(this.MiAjouterTraversee_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(592, 287);
            this.Controls.Add(this.msAccueil);
            this.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.msAccueil;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "FormAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem miAjouterBateau;
        private System.Windows.Forms.ToolStripMenuItem mmAffichage;
        private System.Windows.Forms.ToolStripMenuItem mmEdition;
        private System.Windows.Forms.ToolStripMenuItem miModifierBateau;
        private System.Windows.Forms.ToolStripMenuItem miModifierParametres;
        private System.Windows.Forms.ToolStripMenuItem miAfficherTraversee;
        private System.Windows.Forms.ToolStripMenuItem miAfficherTraverseeLiaison;
        private System.Windows.Forms.ToolStripMenuItem miAfficherDetailReservation;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MiAjouterTraversee;
    }
}

