using PasswordManager.additionalClasses;
using PasswordManager.Forms;
using System;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    public partial class VerificationForm : Form
    {
        private string correctCode;
        private string userEmail;

        public VerificationForm(string email, string code)
        {
            InitializeComponent();
            InitializeWindowLogic();

            this.userEmail = email;
            this.correctCode = code;
        }

        private void InitializeWindowLogic()
        {
            pbClose.Click += (s, e) => Application.Exit();
            pbCollapse.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string inputCode = LTxtCode.Text?.Trim();

            if (inputCode == correctCode)
            {
                ResetPasswordForm resetForm = new ResetPasswordForm(userEmail);
                resetForm.FormClosed += (s, args) => Application.Exit();
                this.Hide();
                resetForm.Show();
            }
            else
            {
                MessageBox.Show("Невірний код! Спробуйте ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}