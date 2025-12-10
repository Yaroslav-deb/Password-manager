using Microsoft.Data.Sqlite;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PasswordManager.database
{
    public static class DatabaseHelper
    {
        private static readonly string ProjectDir =
            Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;

        private static readonly string DbFolder = Path.Combine(ProjectDir, "database");

        private static readonly string DbPath = Path.Combine(DbFolder, "passwordManager.db");

        public static string ConnectionString => $"Data Source={DbPath};";

        public static void InitializeDatabase()
        {
            try
            {
                if (!Directory.Exists(DbFolder))
                    Directory.CreateDirectory(DbFolder);

                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();

                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "PRAGMA foreign_keys = ON;";
                        cmd.ExecuteNonQuery();
                    }

                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = GetInitSql();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка ініціалізації БД: " + ex.Message);
                throw;
            }
        }

        public static SqliteConnection GetConnection()
        {
            var conn = new SqliteConnection(ConnectionString);
            conn.Open();

            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "PRAGMA foreign_keys = ON;";
                cmd.ExecuteNonQuery();
            }
            return conn;
        }

        public static int LoginUser(string loginInput, string password)
        {
            using (var connection = GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "SELECT id, password_hash, kdf_salt FROM users WHERE email = $input OR username = $input";
                command.Parameters.AddWithValue("$input", loginInput);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int userId = reader.GetInt32(0);
                        string storedHash = reader.GetString(1);
                        byte[] saltBytes = (byte[])reader["kdf_salt"];
                        string salt = Convert.ToBase64String(saltBytes);
                        string inputHash = GenerateHash(password, salt);

                        if (storedHash == inputHash) return userId;
                    }
                }
            }
            return -1;
        }

        public static bool RegisterUser(string username, string email, string password)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    string salt = CreateSalt();
                    string hash = GenerateHash(password, salt);
                    byte[] saltBytes = Convert.FromBase64String(salt);

                    var command = connection.CreateCommand();
                    command.CommandText =
                        "INSERT INTO users (username, email, password_hash, kdf_salt) VALUES ($username, $email, $hash, $salt)";

                    command.Parameters.AddWithValue("$username", username);
                    command.Parameters.AddWithValue("$email", email);
                    command.Parameters.AddWithValue("$hash", hash);
                    command.Parameters.AddWithValue("$salt", saltBytes);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (SqliteException ex)
            {
                if (ex.SqliteErrorCode == 19)
                    MessageBox.Show("Цей Email або Логін вже зареєстровано!");
                else
                    MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool UpdateUserPassword(string email, string newPassword)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    string newSalt = CreateSalt();
                    string newHash = GenerateHash(newPassword, newSalt);
                    byte[] newSaltBytes = Convert.FromBase64String(newSalt);

                    var command = connection.CreateCommand();
                    command.CommandText = "UPDATE users SET password_hash = $hash, kdf_salt = $salt WHERE email = $email";

                    command.Parameters.AddWithValue("$hash", newHash);
                    command.Parameters.AddWithValue("$salt", newSaltBytes);
                    command.Parameters.AddWithValue("$email", email);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка оновлення пароля: " + ex.Message);
                return false;
            }
        }

        private static string GenerateHash(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                var combinedBytes = Encoding.UTF8.GetBytes(password + salt);
                var hashBytes = sha256.ComputeHash(combinedBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        private static string CreateSalt()
        {
            byte[] randomBytes = new byte[16];
            using (var generator = RandomNumberGenerator.Create())
            {
                generator.GetBytes(randomBytes);
            }
            return Convert.ToBase64String(randomBytes);
        }

        public static string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            if (image == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        public static Image Base64ToImage(string base64String)
        {
            if (string.IsNullOrEmpty(base64String)) return null;
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return new Bitmap(Image.FromStream(ms));
                }
            }
            catch { return null; }
        }

        private static string GetInitSql()
        {
            return @"
                CREATE TABLE IF NOT EXISTS users (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    username TEXT UNIQUE NOT NULL, 
                    email TEXT UNIQUE NOT NULL,
                    password_hash TEXT NOT NULL, 
                    kdf_salt BLOB NOT NULL,
                    created_at DATETIME DEFAULT CURRENT_TIMESTAMP
                );

                CREATE TABLE IF NOT EXISTS categories (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    name TEXT NOT NULL,
                    user_id INTEGER,
                    FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE
                );

                -- Вставка категорій (Тільки якщо їх немає)
                INSERT INTO categories (name, user_id)
                SELECT 'Робота', NULL WHERE NOT EXISTS (SELECT 1 FROM categories WHERE name = 'Робота' AND user_id IS NULL)
                UNION ALL SELECT 'Розваги', NULL WHERE NOT EXISTS (SELECT 1 FROM categories WHERE name = 'Розваги' AND user_id IS NULL)
                UNION ALL SELECT 'Соціальні мережі', NULL WHERE NOT EXISTS (SELECT 1 FROM categories WHERE name = 'Соціальні мережі' AND user_id IS NULL)
                UNION ALL SELECT 'Фінанси', NULL WHERE NOT EXISTS (SELECT 1 FROM categories WHERE name = 'Фінанси' AND user_id IS NULL)
                UNION ALL SELECT 'Навчання', NULL WHERE NOT EXISTS (SELECT 1 FROM categories WHERE name = 'Навчання' AND user_id IS NULL)
                UNION ALL SELECT 'Покупки', NULL WHERE NOT EXISTS (SELECT 1 FROM categories WHERE name = 'Покупки' AND user_id IS NULL)
                UNION ALL SELECT 'Документи', NULL WHERE NOT EXISTS (SELECT 1 FROM categories WHERE name = 'Документи' AND user_id IS NULL)
                UNION ALL SELECT 'Пошта', NULL WHERE NOT EXISTS (SELECT 1 FROM categories WHERE name = 'Пошта' AND user_id IS NULL)
                UNION ALL SELECT 'Інше', NULL WHERE NOT EXISTS (SELECT 1 FROM categories WHERE name = 'Інше' AND user_id IS NULL);

                CREATE TABLE IF NOT EXISTS entries (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    user_id INTEGER NOT NULL,
                    category_id INTEGER NOT NULL, 
                    title TEXT NOT NULL, 
                    website_url TEXT,
                    icon_base64 TEXT,
                    favorite BOOLEAN DEFAULT 0,
                    encrypted_username BLOB, 
                    encrypted_password BLOB NOT NULL, 
                    encrypted_notes BLOB,             
                    encrypted_totp_secret BLOB,        
                    encryption_iv BLOB NOT NULL, 
                    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
                    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP,
                    FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE,
                    FOREIGN KEY (category_id) REFERENCES categories(id)
                );
            ";
        }
    }
}