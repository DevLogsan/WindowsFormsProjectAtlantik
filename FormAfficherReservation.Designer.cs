
namespace WindowsFormsProjectAtlantik
{
    partial class FormAfficherReservation
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
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.cmbNomPrenom = new System.Windows.Forms.ComboBox();
            this.lvInformation = new System.Windows.Forms.ListView();
            this.gbxReservation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(12, 38);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(76, 13);
            this.lblNomPrenom.TabIndex = 0;
            this.lblNomPrenom.Text = "Nom, prénom :";
            // 
            // cmbNomPrenom
            // 
            this.cmbNomPrenom.FormattingEnabled = true;
            this.cmbNomPrenom.Location = new System.Drawing.Point(94, 35);
            this.cmbNomPrenom.Name = "cmbNomPrenom";
            this.cmbNomPrenom.Size = new System.Drawing.Size(121, 21);
            this.cmbNomPrenom.TabIndex = 1;
            this.cmbNomPrenom.SelectedIndexChanged += new System.EventHandler(this.cmbNomPrenom_SelectedIndexChanged);
            // 
            // lvInformation
            // 
            this.lvInformation.HideSelection = false;
            this.lvInformation.Location = new System.Drawing.Point(15, 187);
            this.lvInformation.Name = "lvInformation";
            this.lvInformation.Size = new System.Drawing.Size(466, 78);
            this.lvInformation.TabIndex = 2;
            this.lvInformation.UseCompatibleStateImageBehavior = false;
            this.lvInformation.SelectedIndexChanged += new System.EventHandler(this.lvInformation_SelectedIndexChanged);
            // 
            // gbxReservation
            // 
            this.gbxReservation.Controls.Add(this.label1);
            this.gbxReservation.Location = new System.Drawing.Point(221, 12);
            this.gbxReservation.Name = "gbxReservation";
            this.gbxReservation.Size = new System.Drawing.Size(260, 169);
            this.gbxReservation.TabIndex = 3;
            this.gbxReservation.TabStop = false;
            this.gbxReservation.Text = "Réservation";
            this.gbxReservation.Enter += new System.EventHandler(this.gbxReservation_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Réglé par carte bancaire";
            // 
            // FormAfficherReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 277);
            this.Controls.Add(this.gbxReservation);
            this.Controls.Add(this.lvInformation);
            this.Controls.Add(this.cmbNomPrenom);
            this.Controls.Add(this.lblNomPrenom);
            this.Name = "FormAfficherReservation";
            this.Text = "FormAfficherReservation";
            this.Load += new System.EventHandler(this.FormAfficherReservation_Load);
            this.gbxReservation.ResumeLayout(false);
            this.gbxReservation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.ComboBox cmbNomPrenom;
        private System.Windows.Forms.ListView lvInformation;
        private System.Windows.Forms.GroupBox gbxReservation;
        private System.Windows.Forms.Label label1;
    }
}