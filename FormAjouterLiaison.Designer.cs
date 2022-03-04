
namespace WindowsFormsProjectAtlantik
{
    partial class FormAjouterLiaison
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
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.cmbArrivee = new System.Windows.Forms.ComboBox();
            this.lblArriee = new System.Windows.Forms.Label();
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.btnAjouterLiaison = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.Location = new System.Drawing.Point(12, 38);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(120, 199);
            this.lbxSecteur.TabIndex = 0;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(12, 9);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(55, 13);
            this.lblSecteur.TabIndex = 1;
            this.lblSecteur.Text = "Secteurs :";
            this.lblSecteur.Click += new System.EventHandler(this.lblSecteur_Click);
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(178, 9);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(45, 13);
            this.lblDepart.TabIndex = 2;
            this.lblDepart.Text = "Depart :";
            this.lblDepart.Click += new System.EventHandler(this.lblDepart_Click);
            // 
            // cmbDepart
            // 
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Location = new System.Drawing.Point(181, 38);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(121, 21);
            this.cmbDepart.TabIndex = 3;
            this.cmbDepart.SelectedIndexChanged += new System.EventHandler(this.cmbDepart_SelectedIndexChanged);
            // 
            // cmbArrivee
            // 
            this.cmbArrivee.FormattingEnabled = true;
            this.cmbArrivee.Location = new System.Drawing.Point(181, 99);
            this.cmbArrivee.Name = "cmbArrivee";
            this.cmbArrivee.Size = new System.Drawing.Size(121, 21);
            this.cmbArrivee.TabIndex = 5;
            this.cmbArrivee.SelectedIndexChanged += new System.EventHandler(this.cmbArrivee_SelectedIndexChanged);
            // 
            // lblArriee
            // 
            this.lblArriee.AutoSize = true;
            this.lblArriee.Location = new System.Drawing.Point(178, 74);
            this.lblArriee.Name = "lblArriee";
            this.lblArriee.Size = new System.Drawing.Size(46, 13);
            this.lblArriee.TabIndex = 4;
            this.lblArriee.Text = "Arrivée :";
            this.lblArriee.Click += new System.EventHandler(this.lblArriee_Click);
            // 
            // tbxDistance
            // 
            this.tbxDistance.Location = new System.Drawing.Point(181, 169);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(121, 20);
            this.tbxDistance.TabIndex = 6;
            this.tbxDistance.TextChanged += new System.EventHandler(this.tbxDistance_TextChanged);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(178, 143);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(55, 13);
            this.lblDistance.TabIndex = 7;
            this.lblDistance.Text = "Distance :";
            this.lblDistance.Click += new System.EventHandler(this.lblDistance_Click);
            // 
            // btnAjouterLiaison
            // 
            this.btnAjouterLiaison.Location = new System.Drawing.Point(181, 214);
            this.btnAjouterLiaison.Name = "btnAjouterLiaison";
            this.btnAjouterLiaison.Size = new System.Drawing.Size(121, 23);
            this.btnAjouterLiaison.TabIndex = 8;
            this.btnAjouterLiaison.Text = "Ajouter";
            this.btnAjouterLiaison.UseVisualStyleBackColor = true;
            this.btnAjouterLiaison.Click += new System.EventHandler(this.btnAjouterLiaison_Click);
            // 
            // FormAjouterLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 251);
            this.Controls.Add(this.btnAjouterLiaison);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.cmbArrivee);
            this.Controls.Add(this.lblArriee);
            this.Controls.Add(this.cmbDepart);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Name = "FormAjouterLiaison";
            this.Text = "FormAjouterLiaison";
            this.Load += new System.EventHandler(this.FormAjouterLiaison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.ComboBox cmbArrivee;
        private System.Windows.Forms.Label lblArriee;
        private System.Windows.Forms.TextBox tbxDistance;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Button btnAjouterLiaison;
    }
}