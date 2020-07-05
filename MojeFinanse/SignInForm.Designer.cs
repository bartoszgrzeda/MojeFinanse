namespace MojeFinanse
{
    partial class SignInForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.signinButton = new System.Windows.Forms.Button();
            this.registerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(107, 44);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(145, 20);
            this.loginBox.TabIndex = 0;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(22, 47);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(36, 13);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(22, 87);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(39, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Hasło:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(107, 84);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(145, 20);
            this.passwordBox.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(25, 143);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(93, 30);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Zamknij";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // signinButton
            // 
            this.signinButton.Location = new System.Drawing.Point(159, 143);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(93, 30);
            this.signinButton.TabIndex = 5;
            this.signinButton.Text = "Zaloguj";
            this.signinButton.UseVisualStyleBackColor = true;
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            // 
            // registerLinkLabel
            // 
            this.registerLinkLabel.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.registerLinkLabel.AutoSize = true;
            this.registerLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.registerLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerLinkLabel.Location = new System.Drawing.Point(34, 185);
            this.registerLinkLabel.Name = "registerLinkLabel";
            this.registerLinkLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.registerLinkLabel.Size = new System.Drawing.Size(223, 13);
            this.registerLinkLabel.TabIndex = 6;
            this.registerLinkLabel.TabStop = true;
            this.registerLinkLabel.Text = "Nie masz konta? Zarejstruj się klikając tutaj!";
            this.registerLinkLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.registerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLinkLabel_LinkClicked);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 220);
            this.Controls.Add(this.registerLinkLabel);
            this.Controls.Add(this.signinButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignInForm_FormClosing);
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.LinkLabel registerLinkLabel;
    }
}

