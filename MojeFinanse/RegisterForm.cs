using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojeFinanse
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.defaultCurrencyComboBox.SelectedIndex = 0;
            this.genderComboBox.SelectedIndex = 0;
            this.isRegisterButton = false;

            birthDateTimePicker.MinDate = new DateTime(1900, 1, 1);
            birthDateTimePicker.MaxDate = DateTime.Today;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void surnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void birthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telephoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void defaultCurrencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void acceptCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void termsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.isRegisterButton = true;
            Close();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.isRegisterButton == false)
            {
                var result = MessageBox.Show("Czy na pewno chcesz zakończyć rejestrację?", "Zamykanie okna rejestracji", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
            else
            {
                string msg = "";

                if (String.IsNullOrEmpty(this.nameBox.Text))
                    msg += "-nie podano imienia\n";

                if (String.IsNullOrEmpty(this.surnameBox.Text))
                    msg += "-nie podano nazwiska\n";

                if (String.IsNullOrEmpty(this.loginBox.Text))
                    msg += "-nie podano loginu\n";

                if (String.IsNullOrEmpty(this.passwordBox.Text))
                    msg += "-nie podano hasła\n";

                if (this.genderComboBox.SelectedIndex == 0)
                    msg += "-nie wybrano płci\n";

                if (this.birthDateTimePicker.Value.AddYears(18).Date > DateTime.Today.Date)
                    msg += "-musisz mieć ukończone 18 lat\n";

                if (String.IsNullOrEmpty(this.emailBox.Text))
                    msg += "-nie podano adresu email\n";

                if (String.IsNullOrEmpty(this.telephoneBox.Text))
                    msg += "-nie podano numeru telefonu\n";

                if (!this.acceptCheckBox.Checked)
                    msg += "-nie zaakceptowano regulaminu\n";

                if (!String.IsNullOrEmpty(msg))
                {
                    var result = MessageBox.Show(msg, "Nieprawidłowe informacje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.isRegisterButton = false;
                    e.Cancel = true;
                }
                else
                {
                    var result2 = MessageBox.Show("Zarejestrowano pomyślnie! Możesz się teraz zalogować.", "Rejestracja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
