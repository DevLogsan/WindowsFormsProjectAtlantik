
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParametre));
            this.tbxMailSite = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.cbxProduction = new System.Windows.Forms.CheckBox();
            this.gbxIdentifiant = new System.Windows.Forms.GroupBox();
            this.tbxIdentifiant = new System.Windows.Forms.TextBox();
            this.tbxCle = new System.Windows.Forms.TextBox();
            this.tbxRang = new System.Windows.Forms.TextBox();
            this.tbxSite = new System.Windows.Forms.TextBox();
            this.lblCle = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblRang = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblMailSite = new System.Windows.Forms.Label();
            this.gbxIdentifiant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxMailSite
            // 
            this.tbxMailSite.Location = new System.Drawing.Point(106, 277);
            this.tbxMailSite.Name = "tbxMailSite";
            this.tbxMailSite.Size = new System.Drawing.Size(180, 20);
            this.tbxMailSite.TabIndex = 8;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(106, 312);
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
            this.cbxProduction.Location = new System.Drawing.Point(106, 247);
            this.cbxProduction.Name = "cbxProduction";
            this.cbxProduction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxProduction.Size = new System.Drawing.Size(92, 17);
            this.cbxProduction.TabIndex = 11;
            this.cbxProduction.Text = "En production";
            this.cbxProduction.UseVisualStyleBackColor = true;
            this.cbxProduction.CheckedChanged += new System.EventHandler(this.cbxProduction_CheckedChanged);
            // 
            // gbxIdentifiant
            // 
            this.gbxIdentifiant.Controls.Add(this.tbxIdentifiant);
            this.gbxIdentifiant.Controls.Add(this.tbxCle);
            this.gbxIdentifiant.Controls.Add(this.tbxRang);
            this.gbxIdentifiant.Controls.Add(this.tbxSite);
            this.gbxIdentifiant.Controls.Add(this.lblCle);
            this.gbxIdentifiant.Controls.Add(this.lblIdentifiant);
            this.gbxIdentifiant.Controls.Add(this.lblRang);
            this.gbxIdentifiant.Controls.Add(this.lblSite);
            this.gbxIdentifiant.Location = new System.Drawing.Point(12, 12);
            this.gbxIdentifiant.Name = "gbxIdentifiant";
            this.gbxIdentifiant.Size = new System.Drawing.Size(274, 229);
            this.gbxIdentifiant.TabIndex = 12;
            this.gbxIdentifiant.TabStop = false;
            this.gbxIdentifiant.Text = "Identiants Paybox";
            this.gbxIdentifiant.Enter += new System.EventHandler(this.gbxIdentifiant_Enter);
            // 
            // tbxIdentifiant
            // 
            this.tbxIdentifiant.Location = new System.Drawing.Point(103, 100);
            this.tbxIdentifiant.Name = "tbxIdentifiant";
            this.tbxIdentifiant.Size = new System.Drawing.Size(137, 20);
            this.tbxIdentifiant.TabIndex = 7;
            // 
            // tbxCle
            // 
            this.tbxCle.Location = new System.Drawing.Point(103, 140);
            this.tbxCle.Name = "tbxCle";
            this.tbxCle.Size = new System.Drawing.Size(137, 20);
            this.tbxCle.TabIndex = 6;
            this.tbxCle.TextChanged += new System.EventHandler(this.tbxCle_TextChanged);
            // 
            // tbxRang
            // 
            this.tbxRang.Location = new System.Drawing.Point(103, 62);
            this.tbxRang.Name = "tbxRang";
            this.tbxRang.Size = new System.Drawing.Size(137, 20);
            this.tbxRang.TabIndex = 5;
            // 
            // tbxSite
            // 
            this.tbxSite.Location = new System.Drawing.Point(103, 27);
            this.tbxSite.Name = "tbxSite";
            this.tbxSite.Size = new System.Drawing.Size(137, 20);
            this.tbxSite.TabIndex = 4;
            // 
            // lblCle
            // 
            this.lblCle.AutoSize = true;
            this.lblCle.Location = new System.Drawing.Point(14, 143);
            this.lblCle.Name = "lblCle";
            this.lblCle.Size = new System.Drawing.Size(28, 13);
            this.lblCle.TabIndex = 3;
            this.lblCle.Text = "Clé :";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(14, 103);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.lblIdentifiant.TabIndex = 2;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // lblRang
            // 
            this.lblRang.AutoSize = true;
            this.lblRang.Location = new System.Drawing.Point(14, 65);
            this.lblRang.Name = "lblRang";
            this.lblRang.Size = new System.Drawing.Size(39, 13);
            this.lblRang.TabIndex = 1;
            this.lblRang.Text = "Rang :";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(14, 30);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(31, 13);
            this.lblSite.TabIndex = 0;
            this.lblSite.Text = "Site :";
            // 
            // lblMailSite
            // 
            this.lblMailSite.AutoSize = true;
            this.lblMailSite.Location = new System.Drawing.Point(26, 281);
            this.lblMailSite.Name = "lblMailSite";
            this.lblMailSite.Size = new System.Drawing.Size(51, 13);
            this.lblMailSite.TabIndex = 13;
            this.lblMailSite.Text = "Mail site :";
            // 
            // FormParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 363);
            this.Controls.Add(this.lblMailSite);
            this.Controls.Add(this.gbxIdentifiant);
            this.Controls.Add(this.cbxProduction);
            this.Controls.Add(this.tbxMailSite);
            this.Controls.Add(this.btnModifier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormParametre";
            this.Text = "FormParametre";
            this.Load += new System.EventHandler(this.FormParametre_Load);
            this.gbxIdentifiant.ResumeLayout(false);
            this.gbxIdentifiant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxMailSite;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.CheckBox cbxProduction;
        private System.Windows.Forms.GroupBox gbxIdentifiant;
        private System.Windows.Forms.Label lblMailSite;
        private System.Windows.Forms.TextBox tbxIdentifiant;
        private System.Windows.Forms.TextBox tbxCle;
        private System.Windows.Forms.TextBox tbxRang;
        private System.Windows.Forms.TextBox tbxSite;
        private System.Windows.Forms.Label lblCle;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblRang;
        private System.Windows.Forms.Label lblSite;
    }
}