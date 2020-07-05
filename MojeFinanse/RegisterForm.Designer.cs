namespace MojeFinanse
{
    partial class RegisterForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.acceptCheckBox = new System.Windows.Forms.CheckBox();
            this.termsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.registerButton = new System.Windows.Forms.Button();
            this.telephoneBox = new System.Windows.Forms.TextBox();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.defaultCurrencyLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.defaultCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(36, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(26, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Imię";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(108, 25);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(108, 60);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(100, 20);
            this.surnameBox.TabIndex = 3;
            this.surnameBox.TextChanged += new System.EventHandler(this.surnameBox_TextChanged);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(36, 67);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(53, 13);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Nazwisko";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(352, 60);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 20);
            this.emailBox.TabIndex = 7;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(239, 63);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(239, 30);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(79, 13);
            this.birthDateLabel.TabIndex = 8;
            this.birthDateLabel.Text = "Data urodzenia";
            // 
            // acceptCheckBox
            // 
            this.acceptCheckBox.AutoSize = true;
            this.acceptCheckBox.Location = new System.Drawing.Point(242, 173);
            this.acceptCheckBox.Name = "acceptCheckBox";
            this.acceptCheckBox.Size = new System.Drawing.Size(74, 17);
            this.acceptCheckBox.TabIndex = 10;
            this.acceptCheckBox.Text = "Akceptuję";
            this.acceptCheckBox.UseVisualStyleBackColor = true;
            this.acceptCheckBox.CheckedChanged += new System.EventHandler(this.acceptCheckBox_CheckedChanged);
            // 
            // termsLinkLabel
            // 
            this.termsLinkLabel.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.termsLinkLabel.AutoSize = true;
            this.termsLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.termsLinkLabel.LinkColor = System.Drawing.SystemColors.Highlight;
            this.termsLinkLabel.Location = new System.Drawing.Point(314, 174);
            this.termsLinkLabel.Name = "termsLinkLabel";
            this.termsLinkLabel.Size = new System.Drawing.Size(57, 13);
            this.termsLinkLabel.TabIndex = 11;
            this.termsLinkLabel.TabStop = true;
            this.termsLinkLabel.Text = "Regulamin";
            this.termsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.termsLinkLabel_LinkClicked);
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = true;
            this.registerButton.Location = new System.Drawing.Point(377, 169);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 12;
            this.registerButton.Text = "Zarejestruj";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // telephoneBox
            // 
            this.telephoneBox.Location = new System.Drawing.Point(352, 98);
            this.telephoneBox.Name = "telephoneBox";
            this.telephoneBox.Size = new System.Drawing.Size(100, 20);
            this.telephoneBox.TabIndex = 14;
            this.telephoneBox.TextChanged += new System.EventHandler(this.telephoneBox_TextChanged);
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(239, 101);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(79, 13);
            this.telephoneLabel.TabIndex = 13;
            this.telephoneLabel.Text = "Numer telefonu";
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateTimePicker.Location = new System.Drawing.Point(352, 24);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.birthDateTimePicker.TabIndex = 15;
            this.birthDateTimePicker.ValueChanged += new System.EventHandler(this.birthDateTimePicker_ValueChanged);
            // 
            // defaultCurrencyLabel
            // 
            this.defaultCurrencyLabel.AutoSize = true;
            this.defaultCurrencyLabel.Location = new System.Drawing.Point(239, 133);
            this.defaultCurrencyLabel.Name = "defaultCurrencyLabel";
            this.defaultCurrencyLabel.Size = new System.Drawing.Size(87, 13);
            this.defaultCurrencyLabel.TabIndex = 16;
            this.defaultCurrencyLabel.Text = "Domyślna waluta";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(108, 130);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 21;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(36, 137);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(36, 13);
            this.passwordLabel.TabIndex = 20;
            this.passwordLabel.Text = "Hasło";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(108, 98);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(100, 20);
            this.loginBox.TabIndex = 19;
            this.loginBox.TextChanged += new System.EventHandler(this.loginBox_TextChanged);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(36, 104);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 18;
            this.loginLabel.Text = "Login";
            // 
            // defaultCurrencyComboBox
            // 
            this.defaultCurrencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultCurrencyComboBox.FormattingEnabled = true;
            this.defaultCurrencyComboBox.Items.AddRange(new object[] {
            "Złoty",
            "Euro",
            "Dolar"});
            this.defaultCurrencyComboBox.Location = new System.Drawing.Point(352, 133);
            this.defaultCurrencyComboBox.Name = "defaultCurrencyComboBox";
            this.defaultCurrencyComboBox.Size = new System.Drawing.Size(100, 21);
            this.defaultCurrencyComboBox.TabIndex = 23;
            this.defaultCurrencyComboBox.SelectedIndexChanged += new System.EventHandler(this.defaultCurrencyComboBox_SelectedIndexChanged);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Wybierz",
            "Mężczyzna",
            "Kobieta"});
            this.genderComboBox.Location = new System.Drawing.Point(108, 166);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(100, 21);
            this.genderComboBox.TabIndex = 25;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.genderComboBox_SelectedIndexChanged);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(36, 169);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(30, 13);
            this.genderLabel.TabIndex = 24;
            this.genderLabel.Text = "Płeć";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 219);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.defaultCurrencyComboBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.defaultCurrencyLabel);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(this.telephoneBox);
            this.Controls.Add(this.telephoneLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.termsLinkLabel);
            this.Controls.Add(this.acceptCheckBox);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestracja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.CheckBox acceptCheckBox;
        private System.Windows.Forms.LinkLabel termsLinkLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox telephoneBox;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.Label defaultCurrencyLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.ComboBox defaultCurrencyComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label genderLabel;
        private bool isRegisterButton;
    }
}