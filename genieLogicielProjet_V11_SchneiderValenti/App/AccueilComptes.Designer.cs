namespace App
{
    partial class AccueilComptes
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
            this.ComptesLB = new System.Windows.Forms.ListBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.progressBarMdp = new System.Windows.Forms.ProgressBar();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.progressBarLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.buttonFormWifi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComptesLB
            // 
            this.ComptesLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ComptesLB.BackColor = System.Drawing.Color.Purple;
            this.ComptesLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComptesLB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComptesLB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ComptesLB.FormattingEnabled = true;
            this.ComptesLB.ItemHeight = 18;
            this.ComptesLB.Location = new System.Drawing.Point(1, -1);
            this.ComptesLB.Name = "ComptesLB";
            this.ComptesLB.Size = new System.Drawing.Size(160, 504);
            this.ComptesLB.TabIndex = 0;
            this.ComptesLB.SelectedIndexChanged += new System.EventHandler(this.ComptesLB_SelectedIndexChanged);
            // 
            // titleTB
            // 
            this.titleTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTB.BackColor = System.Drawing.SystemColors.Desktop;
            this.titleTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTB.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTB.ForeColor = System.Drawing.Color.Orchid;
            this.titleTB.Location = new System.Drawing.Point(304, 33);
            this.titleTB.MaxLength = 62767;
            this.titleTB.Name = "titleTB";
            this.titleTB.ReadOnly = true;
            this.titleTB.Size = new System.Drawing.Size(160, 25);
            this.titleTB.TabIndex = 1;
            this.titleTB.Text = "Titre";
            this.titleTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.Gainsboro;
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(376, 160);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.ReadOnly = true;
            this.passwordTB.Size = new System.Drawing.Size(115, 22);
            this.passwordTB.TabIndex = 10;
            this.passwordTB.TextChanged += new System.EventHandler(this.passwordTB_TextChanged);
            // 
            // loginTB
            // 
            this.loginTB.BackColor = System.Drawing.Color.Gainsboro;
            this.loginTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTB.Location = new System.Drawing.Point(376, 103);
            this.loginTB.Name = "loginTB";
            this.loginTB.ReadOnly = true;
            this.loginTB.Size = new System.Drawing.Size(115, 22);
            this.loginTB.TabIndex = 9;
            // 
            // progressBarMdp
            // 
            this.progressBarMdp.Location = new System.Drawing.Point(218, 279);
            this.progressBarMdp.Name = "progressBarMdp";
            this.progressBarMdp.Size = new System.Drawing.Size(273, 16);
            this.progressBarMdp.Step = 1;
            this.progressBarMdp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarMdp.TabIndex = 4;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.Orchid;
            this.loginLabel.Location = new System.Drawing.Point(213, 104);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(136, 19);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "nom d\'utilisateur";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Orchid;
            this.passwordLabel.Location = new System.Drawing.Point(238, 159);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(111, 19);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "mot de passe";
            // 
            // progressBarLabel
            // 
            this.progressBarLabel.AutoSize = true;
            this.progressBarLabel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarLabel.ForeColor = System.Drawing.Color.Orchid;
            this.progressBarLabel.Location = new System.Drawing.Point(215, 259);
            this.progressBarLabel.Name = "progressBarLabel";
            this.progressBarLabel.Size = new System.Drawing.Size(168, 17);
            this.progressBarLabel.TabIndex = 7;
            this.progressBarLabel.Text = "Force du mot de passe";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(191, 415);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(182, 28);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Ajouter un compte";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(242, 358);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(131, 28);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Modifier";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(410, 359);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(131, 28);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Supprimer";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // buttonFormWifi
            // 
            this.buttonFormWifi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonFormWifi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormWifi.Location = new System.Drawing.Point(410, 415);
            this.buttonFormWifi.Name = "buttonFormWifi";
            this.buttonFormWifi.Size = new System.Drawing.Size(182, 28);
            this.buttonFormWifi.TabIndex = 13;
            this.buttonFormWifi.Text = "Gérer les points Wifi";
            this.buttonFormWifi.UseVisualStyleBackColor = true;
            this.buttonFormWifi.Click += new System.EventHandler(this.buttonFormWifi_Click);
            // 
            // AccueilComptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(619, 495);
            this.Controls.Add(this.buttonFormWifi);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.progressBarLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.progressBarMdp);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.ComptesLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AccueilComptes";
            this.Text = "AccueilComptes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ComptesLB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.ProgressBar progressBarMdp;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label progressBarLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button buttonFormWifi;
    }
}