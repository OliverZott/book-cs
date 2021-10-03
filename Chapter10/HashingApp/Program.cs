using System;
using CryptographyLib;
using static System.Console;

namespace HashingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================== Registration ==================");
            Write("Name: ");
            var name = ReadLine();
            Write("Password: ");
            var pw = ReadLine();

            var user = Protector.Register(name, pw);
            WriteLine("Name: " + user.Name);
            WriteLine("Salt: " + user.Salt);
            WriteLine("SaltedHashedPassword: " + user.SaltedHashedPassword);



            Console.WriteLine("================== Password Check ==================");
            bool isPasswordCorrect = false;
            while (!isPasswordCorrect)
            {
                Write("Enter Name: ");
                var nameInput = ReadLine();
                Write("Enter password: ");
                var passwordInput = ReadLine();

                isPasswordCorrect = Protector.CheckPassword(nameInput, passwordInput);

                if (isPasswordCorrect)
                {
                    WriteLine("Passsword Correct! =)");
                }
                else
                {
                    WriteLine("Wrong password. Please try again:");
                }
            }



        }
    }
}
