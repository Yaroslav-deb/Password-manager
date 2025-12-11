using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PasswordManager.additionalClasses
{
    public static class EncryptionHelper
    {
        private static readonly byte[] AppSecretKey = Encoding.UTF8.GetBytes("12345678901234567890123456789012");

        public static byte[] Encrypt(string plainText, byte[] iv)
        {
            if (string.IsNullOrEmpty(plainText)) return null;

            using (Aes aes = Aes.Create())
            {
                aes.Key = AppSecretKey;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (var sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }
                    return ms.ToArray();
                }
            }
        }

        public static string Decrypt(byte[] cipherText, byte[] iv)
        {
            if (cipherText == null || cipherText.Length == 0) return null;

            using (Aes aes = Aes.Create())
            {
                aes.Key = AppSecretKey;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream(cipherText))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        public static byte[] GenerateIV()
        {
            using (Aes aes = Aes.Create())
            {
                aes.GenerateIV();
                return aes.IV;
            }
        }
    }
}