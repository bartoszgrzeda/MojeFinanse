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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {

            if (this.loginBox.Text == "abc" && this.passwordBox.Text == "cda")
            {
                //Zaloguj
            }
            else
            {
                MessageBox.Show("Nieprawidłowe hasło lub login!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Czy napewno chcesz zamknąć?", "Zamykanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
