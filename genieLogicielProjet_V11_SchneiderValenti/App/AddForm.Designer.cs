namespace App
{
    partial class AddForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.progressBarLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.progressBarMdp = new System.Windows.Forms.ProgressBar();
            this.newLoginTB = new System.Windows.Forms.TextBox();
            this.newPasswordTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.newTitleTB = new System.Windows.Forms.TextBox();
            this.mdpButton = new System.Windows.Forms.Button();
            this.generateMdpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(273, 339);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(131, 28);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(105, 338);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(131, 28);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "Ajouter";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // progressBarLabel
            // 
            this.progressBarLabel.AutoSize = true;
            this.progressBarLabel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarLabel.ForeColor = System.Drawing.Color.Orchid;
            this.progressBarLabel.Location = new System.Drawing.Point(78, 237);
            this.progressBarLabel.Name = "progressBarLabel";
            this.progressBarLabel.Size = new System.Drawing.Size(168, 17);
            this.progressBarLabel.TabIndex = 17;
            this.progressBarLabel.Text = "Force du mot de passe";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Orchid;
            this.passwordLabel.Location = new System.Drawing.Point(101, 137);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(110, 19);
            this.passwordLabel.TabIndex = 16;
            this.passwordLabel.Text = "Mot de passe";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.Orchid;
            this.loginLabel.Location = new System.Drawing.Point(76, 82);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(138, 19);
            this.loginLabel.TabIndex = 15;
            this.loginLabel.Text = "Nom d\'utilisateur";
            // 
            // progressBarMdp
            // 
            this.progressBarMdp.Location = new System.Drawing.Point(81, 257);
            this.progressBarMdp.Name = "progressBarMdp";
            this.progressBarMdp.Size = new System.Drawing.Size(273, 16);
            this.progressBarMdp.Step = 1;
            this.progressBarMdp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarMdp.TabIndex = 14;
            // 
            // newLoginTB
            // 
            this.newLoginTB.BackColor = System.Drawing.Color.White;
            this.newLoginTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newLoginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLoginTB.Location = new System.Drawing.Point(239, 81);
            this.newLoginTB.Name = "newLoginTB";
            this.newLoginTB.Size = new System.Drawing.Size(115, 22);
            this.newLoginTB.TabIndex = 18;
            // 
            // newPasswordTB
            // 
            this.newPasswordTB.BackColor = System.Drawing.Color.White;
            this.newPasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTB.Location = new System.Drawing.Point(239, 138);
            this.newPasswordTB.Name = "newPasswordTB";
            this.newPasswordTB.Size = new System.Drawing.Size(115, 22);
            this.newPasswordTB.TabIndex = 19;
            // 
            // titleTB
            // 
            this.titleTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTB.BackColor = System.Drawing.SystemColors.Desktop;
            this.titleTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTB.ForeColor = System.Drawing.Color.Orchid;
            this.titleTB.Location = new System.Drawing.Point(174, 40);
            this.titleTB.MaxLength = 62767;
            this.titleTB.Name = "titleTB";
            this.titleTB.ReadOnly = true;
            this.titleTB.Size = new System.Drawing.Size(128, 19);
            this.titleTB.TabIndex = 13;
            this.titleTB.Text = "Titre";
            // 
            // newTitleTB
            // 
            this.newTitleTB.BackColor = System.Drawing.Color.White;
            this.newTitleTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newTitleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTitleTB.Location = new System.Drawing.Point(239, 37);
            this.newTitleTB.Name = "newTitleTB";
            this.newTitleTB.Size = new System.Drawing.Size(115, 22);
            this.newTitleTB.TabIndex = 22;
            // 
            // mdpButton
            // 
            this.mdpButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mdpButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdpButton.Location = new System.Drawing.Point(420, 156);
            this.mdpButton.Name = "mdpButton";
            this.mdpButton.Size = new System.Drawing.Size(60, 27);
            this.mdpButton.TabIndex = 23;
            this.mdpButton.Text = "ok";
            this.mdpButton.UseVisualStyleBackColor = true;
            this.mdpButton.Click += new System.EventHandler(this.mdpButton_Click);
            // 
            // generateMdpLabel
            // 
            this.generateMdpLabel.AutoSize = true;
            this.generateMdpLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.generateMdpLabel.ForeColor = System.Drawing.Color.Lavender;
            this.generateMdpLabel.Location = new System.Drawing.Point(360, 137);
            this.generateMdpLabel.Name = "generateMdpLabel";
            this.generateMdpLabel.Size = new System.Drawing.Size(204, 16);
            this.generateMdpLabel.TabIndex = 24;
            this.generateMdpLabel.Text = "Générer automatiquement ?";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(571, 381);
            this.Controls.Add(this.generateMdpLabel);
            this.Controls.Add(this.mdpButton);
            this.Controls.Add(this.newTitleTB);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.progressBarLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.progressBarMdp);
            this.Controls.Add(this.newLoginTB);
            this.Controls.Add(this.newPasswordTB);
            this.Controls.Add(this.titleTB);
            this.Name = "AddForm";
            this.Text = "Ajouter un compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label progressBarLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.ProgressBar progressBarMdp;
        private System.Windows.Forms.TextBox newLoginTB;
        private System.Windows.Forms.TextBox newPasswordTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox newTitleTB;
        private System.Windows.Forms.Button mdpButton;
        private System.Windows.Forms.Label generateMdpLabel;
    }
}