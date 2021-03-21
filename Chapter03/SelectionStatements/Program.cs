using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
        A_label:
            var number = (new Random()).Next(1, 7);
            System.Console.WriteLine($"Next random number: {number}");
            switch (number)
            {
                case 1:
                    System.Console.WriteLine("One");
                    break;
                case 2:
                    System.Console.WriteLine("Two");
                    break;
                case 3:
                case 4:
                    System.Console.WriteLine("Four");
                    goto case 1;
                case 5:
                    System.Console.WriteLine("Five");
                    goto A_label;
                default:
                    System.Console.WriteLine("Default");
                    break;
            }

        }
    }
}
