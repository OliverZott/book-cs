using System;
using System.Security.Cryptography;
using static System.Console;
using CryptographyLib;

namespace EncryptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter text to encrypt: ");
            string message = ReadLine();

            Write("Enter Password: ");
            string password = ReadLine();

            string cryptoText = Protector.Encrypt(message, password);

            WriteLine($"Encrypted text: {cryptoText}");


            Write("Enter password to decrypt: ");
            string passwordInput = ReadLine();

            try
            {
                string clearText = Protector.Decrypt(cryptoText, passwordInput);
                WriteLine($"Decrypted text: {clearText}");
            }
            catch (CryptographicException e)
            {
                WriteLine($"Wrong password. Details: {e.Message}");
            }
            catch (Exception e)
            {
                WriteLine($"Something went wrong: {e.Message}");
            }
        }
    }
}
