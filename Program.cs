using PasswordManager.database;
using PasswordManager.Forms;

namespace PasswordManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DatabaseHelper.InitializeDatabase();
            Application.Run(new LoginForm());

        }
    }
}