using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.additionalClasses
{
    public static class EmailService
    {
        private static readonly string SenderEmail = "yaroslavlpanchonkoln@gmail.com";
        private static readonly string SenderPassword = "inwtibddsgqqkrly";

        public static async Task<bool> SendRecoveryCodeAsync(string recipientEmail, string code)
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(SenderEmail, SenderPassword);

                MailMessage message = new MailMessage();
                message.From = new MailAddress(SenderEmail, "Codewave Security");
                message.To.Add(new MailAddress(recipientEmail));
                message.Subject = "Код відновлення паролю";
                message.Body = $@"
                    <html>
                    <body style='font-family: Arial, sans-serif;'>
                        <h2 style='color: #2191F5;'>Відновлення доступу</h2>
                        <p>Ви запросили зміну паролю для Password Manager.</p>
                        <p>Ваш код підтвердження:</p>
                        <h1 style='background-color: #f0f0f0; padding: 10px; display: inline-block; letter-spacing: 5px;'>{code}</h1>
                        <p>Якщо ви не робили цей запит, просто проігноруйте цей лист.</p>
                    </body>
                    </html>";
                message.IsBodyHtml = true;

                await smtp.SendMailAsync(message);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося відправити Email: " + ex.Message, "Помилка мережі");
                return false;
            }
        }
    }
}