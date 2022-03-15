
namespace WindowsFormsProjectAtlantik
{
    partial class FormAfficherTraversee
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
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.lvInformation = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.dateTraversee = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(12, 282);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(148, 21);
            this.cmbLiaison.TabIndex = 15;
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(9, 266);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblLiaison.TabIndex = 14;
            this.lblLiaison.Text = "Liaison :";
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(12, 11);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(55, 13);
            this.lblSecteur.TabIndex = 13;
            this.lblSecteur.Text = "Secteurs :";
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.Location = new System.Drawing.Point(12, 27);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(151, 225);
            this.lbxSecteur.TabIndex = 12;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // lvInformation
            // 
            this.lvInformation.HideSelection = false;
            this.lvInformation.Location = new System.Drawing.Point(182, 134);
            this.lvInformation.Name = "lvInformation";
            this.lvInformation.Size = new System.Drawing.Size(416, 229);
            this.lvInformation.TabIndex = 16;
            this.lvInformation.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Traversée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Places disponibles par catégorie";
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(304, 69);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(149, 23);
            this.btnAfficher.TabIndex = 19;
            this.btnAfficher.Text = "Afficher les traversées";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // dateTraversee
            // 
            this.dateTraversee.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTraversee.Location = new System.Drawing.Point(500, 27);
            this.dateTraversee.Name = "dateTraversee";
            this.dateTraversee.Size = new System.Drawing.Size(98, 20);
            this.dateTraversee.TabIndex = 20;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(301, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(152, 13);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Date (par défaut date du jour) :";
            // 
            // FormAfficherTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 375);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTraversee);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvInformation);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Name = "FormAfficherTraversee";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormAfficherTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.ListView lvInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.DateTimePicker dateTraversee;
        private System.Windows.Forms.Label lblDate;
    }
}