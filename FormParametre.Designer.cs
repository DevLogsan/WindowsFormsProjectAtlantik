
namespace WindowsFormsProjectAtlantik
{
    partial class FormParametre
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
            this.tbxMailSite = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.cbxProduction = new System.Windows.Forms.CheckBox();
            this.gbxIdentifiant = new System.Windows.Forms.GroupBox();
            this.lblMailSite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxMailSite
            // 
            this.tbxMailSite.Location = new System.Drawing.Point(106, 228);
            this.tbxMailSite.Name = "tbxMailSite";
            this.tbxMailSite.Size = new System.Drawing.Size(180, 20);
            this.tbxMailSite.TabIndex = 8;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(106, 263);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(124, 23);
            this.btnModifier.TabIndex = 10;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // cbxProduction
            // 
            this.cbxProduction.AutoSize = true;
            this.cbxProduction.Location = new System.Drawing.Point(106, 198);
            this.cbxProduction.Name = "cbxProduction";
            this.cbxProduction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxProduction.Size = new System.Drawing.Size(92, 17);
            this.cbxProduction.TabIndex = 11;
            this.cbxProduction.Text = "En production";
            this.cbxProduction.UseVisualStyleBackColor = true;
            // 
            // gbxIdentifiant
            // 
            this.gbxIdentifiant.Location = new System.Drawing.Point(12, 12);
            this.gbxIdentifiant.Name = "gbxIdentifiant";
            this.gbxIdentifiant.Size = new System.Drawing.Size(274, 173);
            this.gbxIdentifiant.TabIndex = 12;
            this.gbxIdentifiant.TabStop = false;
            this.gbxIdentifiant.Text = "Identiants Paybox";
            this.gbxIdentifiant.Enter += new System.EventHandler(this.gbxIdentifiant_Enter);
            // 
            // lblMailSite
            // 
            this.lblMailSite.AutoSize = true;
            this.lblMailSite.Location = new System.Drawing.Point(26, 232);
            this.lblMailSite.Name = "lblMailSite";
            this.lblMailSite.Size = new System.Drawing.Size(51, 13);
            this.lblMailSite.TabIndex = 13;
            this.lblMailSite.Text = "Mail site :";
            // 
            // FormParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 314);
            this.Controls.Add(this.lblMailSite);
            this.Controls.Add(this.gbxIdentifiant);
            this.Controls.Add(this.cbxProduction);
            this.Controls.Add(this.tbxMailSite);
            this.Controls.Add(this.btnModifier);
            this.Name = "FormParametre";
            this.Text = "FormParametre";
            this.Load += new System.EventHandler(this.FormParametre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxMailSite;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.CheckBox cbxProduction;
        private System.Windows.Forms.GroupBox gbxIdentifiant;
        private System.Windows.Forms.Label lblMailSite;
    }
}