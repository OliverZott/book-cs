using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CryptographyLib
{
    public static class Protector
    {
        private static readonly byte[] salt = Encoding.Unicode.GetBytes("7BANANAS");  // Salt size ,ust be at least 8 bytes, we will use 16.
        private static readonly int iterations = 2000;  // Iterations must be at least 1000
        private static Dictionary<string, User> Users = new Dictionary<string, User>();


        public static User Register(string userName, string password)
        {
            // generate random salt and convert to string
            var rng = RandomNumberGenerator.Create();
            var saltBytes = new byte[16];
            rng.GetBytes(saltBytes);
            var saltText = Convert.ToBase64String(saltBytes);

            // generate the salted and hashed pasword
            var saltedHashedPassword = SaltAndHashPassword(password, saltText);

            var user = new User
            {
                Name = userName,
                Salt = saltText,
                SaltedHashedPassword = saltedHashedPassword
            };

            Users.Add(user.Name, user);
            return user;
        }


        private static string SaltAndHashPassword(string password, string saltText)
        {
            var sha = SHA256.Create();
            var saltedPassword = password + salt;
            return Convert.ToBase64String(sha.ComputeHash(Encoding.Unicode.GetBytes(saltedPassword)));
        }


        public static bool CheckPassword(string username, string password)
        {
            if (!Users.ContainsKey(username)) return false;
            var user = Users[username];
            var saltedHashedPassword = SaltAndHashPassword(password, user.Salt);

            return saltedHashedPassword == user.SaltedHashedPassword;
        }


        public static string Encrypt(string plainText, string password)
        {
            byte[] encryptedBytes;
            byte[] plainBytes = Encoding.Unicode.GetBytes(plainText);

            var aes = Aes.Create();  // abstract class factory method
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);

            aes.Key = pbkdf2.GetBytes(32);  // set a 256-bit key
            aes.IV = pbkdf2.GetBytes(16);  // set a 128 bit IV

            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(plainBytes, 0, plainBytes.Length);
                }
                encryptedBytes = ms.ToArray();
            }

            return Convert.ToBase64String(encryptedBytes);
        }


        public static string Decrypt(string cryptoText, string password)
        {
            byte[] plainBytes;
            byte[] cryptoBytes = Convert.FromBase64String(cryptoText);

            var aes = Aes.Create();
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);

            aes.Key = pbkdf2.GetBytes(32);
            aes.IV = pbkdf2.GetBytes(16);

            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(cryptoBytes, 0, cryptoBytes.Length);
                }
                plainBytes = ms.ToArray();
            }
            return Encoding.Unicode.GetString(plainBytes);
        }

    }
}
