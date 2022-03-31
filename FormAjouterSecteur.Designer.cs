
namespace WindowsFormsProjectAtlantik
{
    partial class FormAjouterSecteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouterSecteur));
            this.tbxAjouterSecteur = new System.Windows.Forms.TextBox();
            this.lblNomSecteur = new System.Windows.Forms.Label();
            this.btnAjouterSecteur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxAjouterSecteur
            // 
            this.tbxAjouterSecteur.Location = new System.Drawing.Point(83, 62);
            this.tbxAjouterSecteur.Name = "tbxAjouterSecteur";
            this.tbxAjouterSecteur.Size = new System.Drawing.Size(100, 20);
            this.tbxAjouterSecteur.TabIndex = 0;
            this.tbxAjouterSecteur.TextChanged += new System.EventHandler(this.tbxAjouterSecteur_TextChanged);
            // 
            // lblNomSecteur
            // 
            this.lblNomSecteur.AutoSize = true;
            this.lblNomSecteur.Location = new System.Drawing.Point(80, 46);
            this.lblNomSecteur.Name = "lblNomSecteur";
            this.lblNomSecteur.Size = new System.Drawing.Size(73, 13);
            this.lblNomSecteur.TabIndex = 1;
            this.lblNomSecteur.Text = "Nom secteur :";
            this.lblNomSecteur.Click += new System.EventHandler(this.lblNomSecteur_Click);
            // 
            // btnAjouterSecteur
            // 
            this.btnAjouterSecteur.Location = new System.Drawing.Point(96, 88);
            this.btnAjouterSecteur.Name = "btnAjouterSecteur";
            this.btnAjouterSecteur.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterSecteur.TabIndex = 2;
            this.btnAjouterSecteur.Text = "Ajouter";
            this.btnAjouterSecteur.UseVisualStyleBackColor = true;
            this.btnAjouterSecteur.Click += new System.EventHandler(this.btnAjouterSecteur_Click);
            // 
            // FormAjouterSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 199);
            this.Controls.Add(this.btnAjouterSecteur);
            this.Controls.Add(this.lblNomSecteur);
            this.Controls.Add(this.tbxAjouterSecteur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAjouterSecteur";
            this.Text = "Ajouter un secteur";
            this.Load += new System.EventHandler(this.FormAjouterSecteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAjouterSecteur;
        private System.Windows.Forms.Label lblNomSecteur;
        private System.Windows.Forms.Button btnAjouterSecteur;
    }
}