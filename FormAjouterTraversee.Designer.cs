
namespace WindowsFormsProjectAtlantik
{
    partial class FormAjouterTraversee
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
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.cmbBateau = new System.Windows.Forms.ComboBox();
            this.lblNomBateau = new System.Windows.Forms.Label();
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.dateDepart = new System.Windows.Forms.DateTimePicker();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblArrivee = new System.Windows.Forms.Label();
            this.dateArrivee = new System.Windows.Forms.DateTimePicker();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(12, 11);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(55, 13);
            this.lblSecteur.TabIndex = 3;
            this.lblSecteur.Text = "Secteurs :";
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.Location = new System.Drawing.Point(12, 40);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(120, 199);
            this.lbxSecteur.TabIndex = 2;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // cmbBateau
            // 
            this.cmbBateau.FormattingEnabled = true;
            this.cmbBateau.Location = new System.Drawing.Point(163, 99);
            this.cmbBateau.Name = "cmbBateau";
            this.cmbBateau.Size = new System.Drawing.Size(121, 21);
            this.cmbBateau.TabIndex = 5;
            this.cmbBateau.SelectedIndexChanged += new System.EventHandler(this.cmbBateau_SelectedIndexChanged);
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(160, 73);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(71, 13);
            this.lblNomBateau.TabIndex = 4;
            this.lblNomBateau.Text = "Nom bateau :";
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(163, 40);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaison.TabIndex = 7;
            this.cmbLiaison.SelectedIndexChanged += new System.EventHandler(this.cmbLiaison_SelectedIndexChanged);
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(160, 11);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblLiaison.TabIndex = 6;
            this.lblLiaison.Text = "Liaison :";
            // 
            // dateDepart
            // 
            this.dateDepart.Location = new System.Drawing.Point(306, 41);
            this.dateDepart.Name = "dateDepart";
            this.dateDepart.Size = new System.Drawing.Size(166, 20);
            this.dateDepart.TabIndex = 8;
            this.dateDepart.Value = new System.DateTime(2022, 3, 8, 16, 12, 19, 0);
            this.dateDepart.ValueChanged += new System.EventHandler(this.dateDepart_ValueChanged);
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(303, 11);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(111, 13);
            this.lblDepart.TabIndex = 9;
            this.lblDepart.Text = "Date et heure départ :";
            // 
            // lblArrivee
            // 
            this.lblArrivee.AutoSize = true;
            this.lblArrivee.Location = new System.Drawing.Point(303, 73);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(113, 13);
            this.lblArrivee.TabIndex = 11;
            this.lblArrivee.Text = "Date et heure arrivée :";
            // 
            // dateArrivee
            // 
            this.dateArrivee.Location = new System.Drawing.Point(306, 100);
            this.dateArrivee.Name = "dateArrivee";
            this.dateArrivee.Size = new System.Drawing.Size(166, 20);
            this.dateArrivee.TabIndex = 10;
            this.dateArrivee.Value = new System.DateTime(2022, 3, 8, 16, 12, 19, 0);
            this.dateArrivee.ValueChanged += new System.EventHandler(this.dateArrivee_ValueChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(163, 216);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // FormAjouterTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 263);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblArrivee);
            this.Controls.Add(this.dateArrivee);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.dateDepart);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.cmbBateau);
            this.Controls.Add(this.lblNomBateau);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Name = "FormAjouterTraversee";
            this.Text = "FromAjouterTraversee";
            this.Load += new System.EventHandler(this.FormAjouterTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.ComboBox cmbBateau;
        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.DateTimePicker dateDepart;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblArrivee;
        private System.Windows.Forms.DateTimePicker dateArrivee;
        private System.Windows.Forms.Button btnAjouter;
    }
}