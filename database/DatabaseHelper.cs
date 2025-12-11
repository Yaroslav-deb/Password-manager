using Microsoft.Data.Sqlite;
using PasswordManager.additionalClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

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
                if (!Directory.Exists(DbFolder)) Directory.CreateDirectory(DbFolder);

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
                    command.CommandText = "INSERT INTO users (username, email, password_hash, kdf_salt) VALUES ($username, $email, $hash, $salt)";
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

        public static int GetUserId(string username)
        {
            using (var conn = GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT id FROM users WHERE username = $u";
                cmd.Parameters.AddWithValue("$u", username);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
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

        public static string GetUsernameById(int userId)
        {
            using (var connection = GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "SELECT username FROM users WHERE id = $id";
                command.Parameters.AddWithValue("$id", userId);
                var result = command.ExecuteScalar();
                return result != null ? result.ToString() : "Unknown";
            }
        }

        public static bool AddEntry(int userId, string categoryName, string title, string username, string password, string url, string notes, string iconBase64, bool isFavorite)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    int catId = 1;
                    var cmdCat = conn.CreateCommand();
                    cmdCat.CommandText = "SELECT id FROM categories WHERE name = $name";
                    cmdCat.Parameters.AddWithValue("$name", categoryName);
                    var res = cmdCat.ExecuteScalar();
                    if (res != null) catId = Convert.ToInt32(res);

                    byte[] iv = EncryptionHelper.GenerateIV();
                    byte[] eUser = EncryptionHelper.Encrypt(username, iv);
                    byte[] ePass = EncryptionHelper.Encrypt(password, iv);
                    byte[] eNotes = string.IsNullOrEmpty(notes) ? null : EncryptionHelper.Encrypt(notes, iv);

                    var cmd = conn.CreateCommand();
                    cmd.CommandText = @"
                        INSERT INTO entries (
                            user_id, category_id, title, website_url, 
                            encrypted_username, encrypted_password, encrypted_notes, 
                            encryption_iv, 
                            icon_base64, favorite, -- [НОВЕ]
                            created_at, updated_at
                        ) VALUES (
                            $uid, $cid, $title, $url, 
                            $eUser, $ePass, $eNotes, 
                            $iv, 
                            $icon, $fav, -- [НОВЕ]
                            CURRENT_TIMESTAMP, CURRENT_TIMESTAMP
                        )";

                    cmd.Parameters.AddWithValue("$uid", userId);
                    cmd.Parameters.AddWithValue("$cid", catId);
                    cmd.Parameters.AddWithValue("$title", title);
                    cmd.Parameters.AddWithValue("$url", url);
                    cmd.Parameters.AddWithValue("$eUser", eUser);
                    cmd.Parameters.AddWithValue("$ePass", ePass);
                    cmd.Parameters.AddWithValue("$eNotes", (object)eNotes ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("$iv", iv);

                    // [НОВЕ]
                    cmd.Parameters.AddWithValue("$icon", (object)iconBase64 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("$fav", isFavorite ? 1 : 0);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding entry: " + ex.Message);
                return false;
            }
        }

        public static void UpdateEntryFavorite(int entryId, bool isFavorite)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE entries SET favorite = $fav WHERE id = $id";
                    cmd.Parameters.AddWithValue("$fav", isFavorite ? 1 : 0);
                    cmd.Parameters.AddWithValue("$id", entryId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch { }
        }

        public static bool UpdateEntry(int entryId, int userId, string categoryName, string title, string username, string password, string url, string notes, string iconBase64, bool isFavorite)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    int catId = 1;
                    var cmdCat = conn.CreateCommand();
                    cmdCat.CommandText = "SELECT id FROM categories WHERE name = $name";
                    cmdCat.Parameters.AddWithValue("$name", categoryName);
                    var res = cmdCat.ExecuteScalar();
                    if (res != null) catId = Convert.ToInt32(res);

                    byte[] iv = EncryptionHelper.GenerateIV();
                    byte[] eUser = EncryptionHelper.Encrypt(username, iv);
                    byte[] ePass = EncryptionHelper.Encrypt(password, iv);
                    byte[] eNotes = string.IsNullOrEmpty(notes) ? null : EncryptionHelper.Encrypt(notes, iv);

                    var cmd = conn.CreateCommand();
                    cmd.CommandText = @"
                        UPDATE entries SET
                            category_id = $cid,
                            title = $title,
                            website_url = $url,
                            encrypted_username = $eUser,
                            encrypted_password = $ePass,
                            encrypted_notes = $eNotes,
                            encryption_iv = $iv,
                            icon_base64 = $icon,
                            favorite = $fav,
                            updated_at = CURRENT_TIMESTAMP
                        WHERE id = $id AND user_id = $uid";

                    cmd.Parameters.AddWithValue("$id", entryId);
                    cmd.Parameters.AddWithValue("$uid", userId);
                    cmd.Parameters.AddWithValue("$cid", catId);
                    cmd.Parameters.AddWithValue("$title", title);
                    cmd.Parameters.AddWithValue("$url", (object)url ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("$eUser", eUser);
                    cmd.Parameters.AddWithValue("$ePass", ePass);
                    cmd.Parameters.AddWithValue("$eNotes", (object)eNotes ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("$iv", iv);

                    cmd.Parameters.AddWithValue("$icon", (object)iconBase64 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("$fav", isFavorite ? 1 : 0);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка оновлення: " + ex.Message);
                return false;
            }
        }

        public static List<PasswordEntry> GetEntries(int userId)
        {
            var list = new List<PasswordEntry>();
            try
            {
                using (var conn = GetConnection())
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = @"
                        SELECT e.id, e.title, e.website_url, e.icon_base64, e.updated_at, c.name, e.favorite,
                               e.encrypted_username, e.encryption_iv, 
                               e.encrypted_password, e.encrypted_notes
                        FROM entries e
                        JOIN categories c ON e.category_id = c.id
                        WHERE e.user_id = $uid
                        ORDER BY e.updated_at DESC";

                    cmd.Parameters.AddWithValue("$uid", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] eUser = reader["encrypted_username"] as byte[];
                            byte[] ePass = reader["encrypted_password"] as byte[];
                            byte[] eNotes = reader["encrypted_notes"] as byte[];
                            byte[] iv = reader["encryption_iv"] as byte[];

                            string decryptedUser = EncryptionHelper.Decrypt(eUser, iv);

                            list.Add(new PasswordEntry
                            {
                                Id = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                WebsiteUrl = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                IconBase64 = reader.IsDBNull(3) ? null : reader.GetString(3),
                                UpdatedAt = reader.GetDateTime(4),
                                Category = reader.GetString(5),
                                Favorite = reader.GetBoolean(6),
                                Username = decryptedUser,

                                EncryptedPassword = ePass,
                                EncryptionIV = iv,
                                EncryptedNotes = eNotes
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження: " + ex.Message);
            }
            return list;
        }

        public static bool MoveToTrash(int entryId)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    using (var transaction = conn.BeginTransaction())
                    {
                        var cmdCopy = conn.CreateCommand();
                        cmdCopy.Transaction = transaction;
                        cmdCopy.CommandText = @"
                            INSERT INTO trash (original_id, user_id, category_id, title, website_url, 
                                               encrypted_username, encrypted_password, encrypted_notes, 
                                               encryption_iv, icon_base64, favorite, created_at, updated_at)
                            SELECT id, user_id, category_id, title, website_url, 
                                   encrypted_username, encrypted_password, encrypted_notes, 
                                   encryption_iv, icon_base64, favorite, created_at, updated_at
                            FROM entries WHERE id = $id";
                        cmdCopy.Parameters.AddWithValue("$id", entryId);
                        cmdCopy.ExecuteNonQuery();

                        var cmdDel = conn.CreateCommand();
                        cmdDel.Transaction = transaction;
                        cmdDel.CommandText = "DELETE FROM entries WHERE id = $id";
                        cmdDel.Parameters.AddWithValue("$id", entryId);
                        cmdDel.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                }
            }
            catch { return false; }
        }

        public static AutoCompleteStringCollection GetAutoSuggestionList()
        {
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            try
            {
                using (var conn = GetConnection())
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT DISTINCT title FROM entries UNION SELECT DISTINCT website_url FROM entries";
                    using (var r = cmd.ExecuteReader()) while (r.Read()) if (!r.IsDBNull(0)) col.Add(r.GetString(0));
                }
            }
            catch { }
            return col;
        }

        public static (string Level, Color Color, string Message) EvaluatePasswordStrength(string password)
        {
            if (string.IsNullOrEmpty(password)) return ("Немає", Color.Gray, "");
            int s = 0;
            if (password.Length >= 8) s++;
            if (password.Length >= 12) s++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[A-Z]")) s++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[0-9]")) s++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[!@#$%^&*]")) s++;

            if (s < 2) return ("Слабкий", Color.Red, "Легко зламати");
            if (s < 4) return ("Середній", Color.Orange, "Краще додати символів");
            return ("Відмінний", Color.Green, "Надійний пароль");
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

        // --- ІНІЦІАЛІЗАЦІЯ БД ---
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

                CREATE TABLE IF NOT EXISTS trash (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    original_id INTEGER,
                    user_id INTEGER NOT NULL,
                    category_id INTEGER NOT NULL, 
                    title TEXT, 
                    website_url TEXT,
                    icon_base64 TEXT,
                    favorite BOOLEAN,
                    encrypted_username BLOB, 
                    encrypted_password BLOB, 
                    encrypted_notes BLOB,              
                    encryption_iv BLOB, 
                    created_at DATETIME,
                    updated_at DATETIME,
                    deleted_at DATETIME DEFAULT CURRENT_TIMESTAMP,
                    FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE
                );
            ";
        }
    }
}