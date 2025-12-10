using PasswordManager.additionalClasses;
using System;
using System.Drawing;
using System.Text.RegularExpressions; // Для перевірки пошти
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
            InitializeWindowLogic();
        }

        // --- НАЛАШТУВАННЯ ВІКНА ---
        private void InitializeWindowLogic()
        {
            // Закриття програми повністю при натисканні на хрестик
            pbClose.Click += (s, e) => Application.Exit();
            pbClose.Cursor = Cursors.Hand;

            // Згортання вікна
            pbCollapse.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            pbCollapse.Cursor = Cursors.Hand;
        }

        // --- ЛОГІКА ВІДНОВЛЕННЯ ---
        private async void btnSend_Click(object sender, EventArgs e)
        {
            string email = LTxtEmail.Text?.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Будь ласка, введіть Email.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Некоректний формат Email.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Генеруємо код
            Random rnd = new Random();
            string code = rnd.Next(100000, 999999).ToString();

            // 2. Блокуємо кнопку, щоб не натискали двічі
            btnSend.Enabled = false;
            btnSend.Text = "Відправка...";
            this.Cursor = Cursors.WaitCursor; // Курсор "очікування"

            // 3. Реальна відправка Email
            bool isSent = await EmailService.SendRecoveryCodeAsync(email, code);

            // 4. Повертаємо інтерфейс назад
            this.Cursor = Cursors.Default;
            btnSend.Enabled = true;
            btnSend.Text = "Відправити";

            if (isSent)
            {
                MessageBox.Show($"Код успішно відправлено на {email}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Перехід на форму введення коду
                VerificationForm verifyForm = new VerificationForm(email, code);
                verifyForm.FormClosed += (s, args) => Application.Exit();
                this.Hide();
                verifyForm.Show();
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern);
            }
            catch
            {
                return false;
            }
        }

        // --- НАВІГАЦІЯ ---
        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            GoBackToLogin();
        }

        private void GoBackToLogin()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => Application.Exit();
            this.Hide();
            loginForm.Show();
        }
    }
}