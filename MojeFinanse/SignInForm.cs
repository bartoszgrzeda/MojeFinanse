using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
                this.Close();
        }

        private bool CheckTheLoginPass()
        {
            if (this.loginBox.Text == "abc" && this.passwordBox.Text == "cda") 
                return true;
            else 
                return false;
        }

        private void signinButton_Click(object sender, EventArgs e)
        {

            if (CheckTheLoginPass())
            {
                //Application.Run(new MainForm()); to nie działa ale ty pewnie wiesz jak to zrobić
                // a ja sobie tak tylko aby próbowałem
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
                e.Cancel = true;
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
