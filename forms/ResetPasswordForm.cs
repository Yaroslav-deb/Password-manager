using PasswordManager.additionalClasses;
using PasswordManager.database;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    public partial class ResetPasswordForm : Form
    {
        private string userEmail;

        private Image imgEyeShow;
        private Image imgEyeHide;

        public ResetPasswordForm(string email)
        {
            InitializeComponent();
            InitializeWindowLogic();
            this.userEmail = email;

            LoadIcons();
        }

        private void InitializeWindowLogic()
        {
            pbClose.Click += (s, e) => Application.Exit();
            pbClose.Cursor = Cursors.Hand;

            pbCollapse.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            pbCollapse.Cursor = Cursors.Hand;

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
            TogglePasswordVisibility(LTxtConfirm, pbEyeConfirm);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pass1 = LTxtPassword.Text;
            string pass2 = LTxtConfirm.Text;

            if (string.IsNullOrEmpty(pass1) || string.IsNullOrEmpty(pass2))
            {
                MessageBox.Show("Заповніть усі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass1 != pass2)
            {
                MessageBox.Show("Паролі не співпадають!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = DatabaseHelper.UpdateUserPassword(userEmail, pass1);

            if (success)
            {
                MessageBox.Show("Пароль успішно змінено! Увійдіть з новим паролем.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoginForm login = new LoginForm();
                login.FormClosed += (s, args) => Application.Exit();
                this.Hide();
                login.Show();
            }
            else
            {
                MessageBox.Show("Помилка при оновленні пароля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}