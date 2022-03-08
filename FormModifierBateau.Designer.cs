namespace WindowsFormsProjectAtlantik
{
    partial class FormModifierBateau
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
            this.cmbNomBateau = new System.Windows.Forms.ComboBox();
            this.gbxGroupe = new System.Windows.Forms.GroupBox();
            this.btnModifier = new System.Windows.Forms.Button();
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
            // cmbNomBateau
            // 
            this.cmbNomBateau.FormattingEnabled = true;
            this.cmbNomBateau.Location = new System.Drawing.Point(127, 42);
            this.cmbNomBateau.Name = "cmbNomBateau";
            this.cmbNomBateau.Size = new System.Drawing.Size(100, 21);
            this.cmbNomBateau.TabIndex = 1;
            this.cmbNomBateau.SelectedIndexChanged += new System.EventHandler(this.cmbNomBateau_SelectedIndexChanged);
            // 
            // gbxGroupe
            // 
            this.gbxGroupe.Location = new System.Drawing.Point(242, 42);
            this.gbxGroupe.Name = "gbxGroupe";
            this.gbxGroupe.Size = new System.Drawing.Size(247, 196);
            this.gbxGroupe.TabIndex = 6;
            this.gbxGroupe.TabStop = false;
            this.gbxGroupe.Text = "Capacités Maximales";
            this.gbxGroupe.Enter += new System.EventHandler(this.gbxGroupe_Enter);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(316, 244);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 23);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // FormModifierBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 287);
            this.Controls.Add(this.gbxGroupe);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.cmbNomBateau);
            this.Controls.Add(this.lblNomBateau);
            this.Name = "FormModifierBateau";
            this.Text = "Modifier un bateau";
            this.Load += new System.EventHandler(this.FormModifierBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.ComboBox cmbNomBateau;
        private System.Windows.Forms.GroupBox gbxGroupe;
        private System.Windows.Forms.Button btnModifier;
    }
}