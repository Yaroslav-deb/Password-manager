using System;

namespace PasswordManager.database
{
    public class PasswordEntry
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public string WebsiteUrl { get; set; }
        public string Category { get; set; }
        public string IconBase64 { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Favorite { get; set; }
        public byte[] EncryptedPassword { get; set; }
        public byte[] EncryptionIV { get; set; }
        public byte[] EncryptedNotes { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}