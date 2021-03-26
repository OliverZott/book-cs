using System;

namespace WritingFunctions
{
    class Program
    {


        // Example3
        static int Factorial(int input)
        {
            if (input < 1)
            {
                return 0;
            }
            else if (input == 1)
            {
                return 1;
            }
            else
            {
                checked
                {
                    return input * Factorial(input - 1);
                }
            }
        }


        // Example 2
        static void TimesTable(byte number)
        {
            for (int row = 1; row <= 12; row++)
            {
                System.Console.WriteLine($"{row} x number = {row * number}");
            }
            System.Console.WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;

            do
            {
                System.Console.WriteLine("Enter a number between 0 and 255: ");

                isNumber = byte.TryParse(Console.ReadLine(), out byte number);

                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    System.Console.WriteLine("You did not enter a valid number.");
                }
            }
            while (isNumber);
        }


        // Example 1
        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {

            decimal rate = 0.0M;

            switch (twoLetterRegionCode)
            {
                case "CH":
                    rate = 0.08M;
                    break;
                case "AT":
                    rate = 0.2M;
                    break;
                case "DK":
                case "MT":
                    rate = 0.0M;
                    break;
                default:
                    rate = 0.06M;
                    break;
            }
            return rate * amount;
        }

        static void RunCalculateTax()
        {

            System.Console.WriteLine("Please Enter amount of money: ");
            string amountInText = System.Console.ReadLine();

            System.Console.WriteLine("Please enter Region Code (two letters): ");
            string region = System.Console.ReadLine();

            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal result = CalculateTax(amount, region);
                System.Console.WriteLine($"You have to pay {result}Euro in taxes");
            }
            else
            {
                System.Console.WriteLine("Wrong input");
            }

        }

        static void Main(string[] args)
        {
            //RunTimesTable(); 
            //RunCalculateTax();

            try
            {
                System.Console.WriteLine($"17! = {Factorial(17)}");

            }
            catch (System.Exception exc)
            {
                System.Console.WriteLine($"Number too big for 32bit Integer ({exc.GetType()})");
            }

        }
    }
}
