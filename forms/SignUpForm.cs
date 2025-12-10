using PasswordManager.additionalClasses;
using PasswordManager.database;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    public partial class SignUpForm : Form
    {
        private Image imgEyeShow;
        private Image imgEyeHide;

        public SignUpForm()
        {
            InitializeComponent();
            InitializeWindowLogic();
            LoadIcons();
        }

        private void InitializeWindowLogic()
        {
            pbClose.Click += (s, e) => Application.Exit();
            pbCollapse.Click += (s, e) => this.WindowState = FormWindowState.Minimized;

            pbEyePass.BringToFront();
            pbEyeConfirm.BringToFront();
        }

        private void LoadIcons()
        {
            try
            {
                string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
                string photosFolderPath = Path.Combine(projectDir, "photos");

                string pathShow = Path.Combine(photosFolderPath, "eye_show.png");
                string pathHide = Path.Combine(photosFolderPath, "eye_hide.png");

                if (File.Exists(pathShow) && File.Exists(pathHide))
                {
                    using (FileStream fs = new FileStream(pathShow, FileMode.Open, FileAccess.Read))
                        imgEyeShow = Image.FromStream(fs);

                    using (FileStream fs = new FileStream(pathHide, FileMode.Open, FileAccess.Read))
                        imgEyeHide = Image.FromStream(fs);

                    pbEyePass.Image = imgEyeHide;
                    pbEyeConfirm.Image = imgEyeHide;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка іконок: " + ex.Message);
            }
        }

        private void pbEyePass_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(LTxtPassword, pbEyePass);
        }

        private void pbEyeConfirm_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(LTxtConfirmPass, pbEyeConfirm);
        }

        private void TogglePasswordVisibility(personalizedTools.LoginTextBox targetField, PictureBox eyeIcon)
        {
            if (imgEyeShow == null || imgEyeHide == null) return;

            targetField.isPassword = !targetField.isPassword;

            if (targetField.isPassword)
            {
                eyeIcon.Image = imgEyeHide;
            }
            else
            {
                eyeIcon.Image = imgEyeShow;
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => Application.Exit();
            this.Hide();
            loginForm.Show();
        }

        private void rbRegister_Click(object sender, EventArgs e)
        {
            string username = LTxtUsername.Text?.Trim();
            string email = LTxtEmail.Text?.Trim();
            string pass1 = LTxtPassword.Text;
            string pass2 = LTxtConfirmPass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(pass1) || string.IsNullOrEmpty(pass2))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Введено некоректний формат Email!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass1 != pass2)
            {
                MessageBox.Show("Паролі не співпадають!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isRegistered = DatabaseHelper.RegisterUser(username, email, pass1);

            if (isRegistered)
            {
                MessageBox.Show("Реєстрація успішна! Тепер ви можете увійти.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblLogin_Click(sender, e);
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}