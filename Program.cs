using PasswordManager.database;
using PasswordManager.Forms;

namespace PasswordManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DatabaseHelper.InitializeDatabase();
            Application.Run(new MainForm(1));

        }
    }
}