namespace App
{
    partial class FormWifi
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
            this.WifiLB = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.progressBarLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.ssidLabel = new System.Windows.Forms.Label();
            this.progressBarMdp = new System.Windows.Forms.ProgressBar();
            this.ssidTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WifiLB
            // 
            this.WifiLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WifiLB.BackColor = System.Drawing.Color.Purple;
            this.WifiLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WifiLB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WifiLB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.WifiLB.FormattingEnabled = true;
            this.WifiLB.ItemHeight = 18;
            this.WifiLB.Location = new System.Drawing.Point(0, 0);
            this.WifiLB.Name = "WifiLB";
            this.WifiLB.Size = new System.Drawing.Size(160, 504);
            this.WifiLB.TabIndex = 15;
            this.WifiLB.SelectedIndexChanged += new System.EventHandler(this.WifiLB_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(411, 366);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(131, 28);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.Text = "Supprimer";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(243, 365);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(131, 28);
            this.updateButton.TabIndex = 24;
            this.updateButton.Text = "Modifier";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(301, 422);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(182, 28);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Ajouter un point wifi";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // progressBarLabel
            // 
            this.progressBarLabel.AutoSize = true;
            this.progressBarLabel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarLabel.ForeColor = System.Drawing.Color.Orchid;
            this.progressBarLabel.Location = new System.Drawing.Point(216, 266);
            this.progressBarLabel.Name = "progressBarLabel";
            this.progressBarLabel.Size = new System.Drawing.Size(168, 17);
            this.progressBarLabel.TabIndex = 20;
            this.progressBarLabel.Text = "Force du mot de passe";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Orchid;
            this.passwordLabel.Location = new System.Drawing.Point(239, 166);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(111, 19);
            this.passwordLabel.TabIndex = 19;
            this.passwordLabel.Text = "mot de passe";
            // 
            // ssidLabel
            // 
            this.ssidLabel.AutoSize = true;
            this.ssidLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssidLabel.ForeColor = System.Drawing.Color.Orchid;
            this.ssidLabel.Location = new System.Drawing.Point(239, 113);
            this.ssidLabel.Name = "ssidLabel";
            this.ssidLabel.Size = new System.Drawing.Size(110, 19);
            this.ssidLabel.TabIndex = 18;
            this.ssidLabel.Text = "numéro SSID";
            // 
            // progressBarMdp
            // 
            this.progressBarMdp.Location = new System.Drawing.Point(219, 286);
            this.progressBarMdp.Name = "progressBarMdp";
            this.progressBarMdp.Size = new System.Drawing.Size(273, 16);
            this.progressBarMdp.Step = 1;
            this.progressBarMdp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarMdp.TabIndex = 17;
            // 
            // ssidTB
            // 
            this.ssidTB.BackColor = System.Drawing.Color.Gainsboro;
            this.ssidTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ssidTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssidTB.Location = new System.Drawing.Point(377, 110);
            this.ssidTB.Name = "ssidTB";
            this.ssidTB.ReadOnly = true;
            this.ssidTB.Size = new System.Drawing.Size(115, 22);
            this.ssidTB.TabIndex = 22;
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.Gainsboro;
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(377, 166);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.ReadOnly = true;
            this.passwordTB.Size = new System.Drawing.Size(115, 22);
            this.passwordTB.TabIndex = 23;
            this.passwordTB.TextChanged += new System.EventHandler(this.passwordTB_TextChanged);
            // 
            // titleTB
            // 
            this.titleTB.BackColor = System.Drawing.SystemColors.Desktop;
            this.titleTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTB.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTB.ForeColor = System.Drawing.Color.Orchid;
            this.titleTB.Location = new System.Drawing.Point(305, 40);
            this.titleTB.MaxLength = 62767;
            this.titleTB.Name = "titleTB";
            this.titleTB.ReadOnly = true;
            this.titleTB.Size = new System.Drawing.Size(178, 25);
            this.titleTB.TabIndex = 16;
            this.titleTB.Text = "Titre";
            this.titleTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormWifi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(632, 499);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.progressBarLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.ssidLabel);
            this.Controls.Add(this.progressBarMdp);
            this.Controls.Add(this.ssidTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.WifiLB);
            this.Name = "FormWifi";
            this.Text = "Wifi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WifiLB;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label progressBarLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label ssidLabel;
        private System.Windows.Forms.ProgressBar progressBarMdp;
        private System.Windows.Forms.TextBox ssidTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox titleTB;
    }
}