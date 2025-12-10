using PasswordManager.additionalClasses;
using PasswordManager.database;
using PasswordManager.forms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace PasswordManager.Forms
{
    public partial class LoginForm : Form
    {
        private Image imgEyeShow;
        private Image imgEyeHide;

        public LoginForm()
        {
            InitializeComponent();
            InitializeWindowLogic();
            LoadIcons();
        }

        private void InitializeWindowLogic()
        {
            pbClose.Click += (s, e) => Application.Exit();
            pbClose.Cursor = Cursors.Hand;

            pbCollapse.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            pbCollapse.Cursor = Cursors.Hand;

            pbEyePass.BringToFront();
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
                    {
                        imgEyeShow = Image.FromStream(fs);
                    }
                    using (FileStream fs = new FileStream(pathHide, FileMode.Open, FileAccess.Read))
                    {
                        imgEyeHide = Image.FromStream(fs);
                    }
                    pbEyePass.Image = imgEyeHide;
                }
                else
                {
                    MessageBox.Show($"Не знайдено фото: {pathShow}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка іконок: " + ex.Message);
            }
        }

        private void pbEyePass_Click(object sender, EventArgs e)
        {
            if (imgEyeShow == null || imgEyeHide == null) return;

            LTxtPassword.isPassword = !LTxtPassword.isPassword;

            if (LTxtPassword.isPassword)
            {
                pbEyePass.Image = imgEyeHide;
            }
            else
            {
                pbEyePass.Image = imgEyeShow;
            }
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.FormClosed += (s, args) => Application.Exit();
            this.Hide();
            signUpForm.Show();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotForm = new ForgotPasswordForm();
            forgotForm.FormClosed += (s, args) => Application.Exit();
            this.Hide();
            forgotForm.Show();
        }

        private void rbLogin_Click(object sender, EventArgs e)
        {
            string loginInput = LTxtUsername.Text?.Trim();
            string password = LTxtPassword.Text;

            if (string.IsNullOrEmpty(loginInput) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Будь ласка, заповніть логін та пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = DatabaseHelper.LoginUser(loginInput, password);

            if (userId != -1)
            {
                MessageBox.Show($"ID: {userId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Невірний логін або пароль.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}