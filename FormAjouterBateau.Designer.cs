
namespace WindowsFormsProjectAtlantik
{
    partial class FormAjouterBateau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomBateau = new System.Windows.Forms.Label();
            this.tbxNomBateau = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.gbxGroupe = new System.Windows.Forms.GroupBox();
            this.mmAjout = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterSecteur = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterPort = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterLiaison = new System.Windows.Forms.ToolStripMenuItem();
            this.miBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterTarif = new System.Windows.Forms.ToolStripMenuItem();
            this.mmEdition = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifierBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifierParametres = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAffichage = new System.Windows.Forms.ToolStripMenuItem();
            this.miAfficherTraversee = new System.Windows.Forms.ToolStripMenuItem();
            this.miAfficherTraverseeLiaison = new System.Windows.Forms.ToolStripMenuItem();
            this.miAfficherDetailReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(35, 42);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(86, 13);
            this.lblNomBateau.TabIndex = 0;
            this.lblNomBateau.Text = "Nom du bateau :";
            this.lblNomBateau.Click += new System.EventHandler(this.lblNomBateau_Click);
            // 
            // tbxNomBateau
            // 
            this.tbxNomBateau.Location = new System.Drawing.Point(127, 42);
            this.tbxNomBateau.Name = "tbxNomBateau";
            this.tbxNomBateau.Size = new System.Drawing.Size(100, 20);
            this.tbxNomBateau.TabIndex = 1;
            this.tbxNomBateau.TextChanged += new System.EventHandler(this.tbxNomBateau_TextChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(320, 244);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 23);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // gbxGroupe
            // 
            this.gbxGroupe.Location = new System.Drawing.Point(242, 42);
            this.gbxGroupe.Name = "gbxGroupe";
            this.gbxGroupe.Size = new System.Drawing.Size(247, 196);
            this.gbxGroupe.TabIndex = 4;
            this.gbxGroupe.TabStop = false;
            this.gbxGroupe.Text = "Capacités Maximales";
            this.gbxGroupe.Enter += new System.EventHandler(this.gbxGroupe_Enter);
            // 
            // mmAjout
            // 
            this.mmAjout.Name = "mmAjout";
            this.mmAjout.Size = new System.Drawing.Size(32, 19);
            // 
            // miAjouterSecteur
            // 
            this.miAjouterSecteur.Name = "miAjouterSecteur";
            this.miAjouterSecteur.Size = new System.Drawing.Size(32, 19);
            // 
            // miAjouterPort
            // 
            this.miAjouterPort.Name = "miAjouterPort";
            this.miAjouterPort.Size = new System.Drawing.Size(32, 19);
            // 
            // miAjouterLiaison
            // 
            this.miAjouterLiaison.Name = "miAjouterLiaison";
            this.miAjouterLiaison.Size = new System.Drawing.Size(32, 19);
            // 
            // miBateau
            // 
            this.miBateau.Name = "miBateau";
            this.miBateau.Size = new System.Drawing.Size(32, 19);
            // 
            // miAjouterTarif
            // 
            this.miAjouterTarif.Name = "miAjouterTarif";
            this.miAjouterTarif.Size = new System.Drawing.Size(32, 19);
            // 
            // mmEdition
            // 
            this.mmEdition.Name = "mmEdition";
            this.mmEdition.Size = new System.Drawing.Size(32, 19);
            // 
            // miModifierBateau
            // 
            this.miModifierBateau.Name = "miModifierBateau";
            this.miModifierBateau.Size = new System.Drawing.Size(32, 19);
            // 
            // miModifierParametres
            // 
            this.miModifierParametres.Name = "miModifierParametres";
            this.miModifierParametres.Size = new System.Drawing.Size(32, 19);
            // 
            // mmAffichage
            // 
            this.mmAffichage.Name = "mmAffichage";
            this.mmAffichage.Size = new System.Drawing.Size(32, 19);
            // 
            // miAfficherTraversee
            // 
            this.miAfficherTraversee.Name = "miAfficherTraversee";
            this.miAfficherTraversee.Size = new System.Drawing.Size(32, 19);
            // 
            // miAfficherTraverseeLiaison
            // 
            this.miAfficherTraverseeLiaison.Name = "miAfficherTraverseeLiaison";
            this.miAfficherTraverseeLiaison.Size = new System.Drawing.Size(32, 19);
            // 
            // miAfficherDetailReservation
            // 
            this.miAfficherDetailReservation.Name = "miAfficherDetailReservation";
            this.miAfficherDetailReservation.Size = new System.Drawing.Size(32, 19);
            // 
            // FormAjouterBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 287);
            this.Controls.Add(this.gbxGroupe);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tbxNomBateau);
            this.Controls.Add(this.lblNomBateau);
            this.Name = "FormAjouterBateau";
            this.Text = "Ajouter un bateau";
            this.Load += new System.EventHandler(this.FormAjouterBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.TextBox tbxNomBateau;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox gbxGroupe;
        private System.Windows.Forms.ToolStripMenuItem mmAjout;
        private System.Windows.Forms.ToolStripMenuItem miAjouterSecteur;
        private System.Windows.Forms.ToolStripMenuItem miAjouterPort;
        private System.Windows.Forms.ToolStripMenuItem miAjouterLiaison;
        private System.Windows.Forms.ToolStripMenuItem miBateau;
        private System.Windows.Forms.ToolStripMenuItem miAjouterTarif;
        private System.Windows.Forms.ToolStripMenuItem mmEdition;
        private System.Windows.Forms.ToolStripMenuItem miModifierBateau;
        private System.Windows.Forms.ToolStripMenuItem miModifierParametres;
        private System.Windows.Forms.ToolStripMenuItem mmAffichage;
        private System.Windows.Forms.ToolStripMenuItem miAfficherTraversee;
        private System.Windows.Forms.ToolStripMenuItem miAfficherTraverseeLiaison;
        private System.Windows.Forms.ToolStripMenuItem miAfficherDetailReservation;
    }
}