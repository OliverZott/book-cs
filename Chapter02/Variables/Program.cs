using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            // object has to be casted
            object hight = 1.88;
            object name = "Olli";
            Console.WriteLine($"{name} is  {hight} tall.");

            // int length1 = name.Length;           // compile error            
            int length2 = ((String) name).Length;   // tell compiler its a string
            System.Console.WriteLine($"{name} has {length2} characters.");


            // dynamic doesnt need type casting
            dynamic anotherName = "Lena";
            int length3 = anotherName.Length;
            Console.WriteLine(length3);

            // Default values
            System.Console.WriteLine($"Default(int) = {default(int)}");
            System.Console.WriteLine($"Default(bool) = {default(bool)}");
            System.Console.WriteLine($"Default(DateTime) = {default(DateTime)}");
            System.Console.WriteLine($"Default(string) = {default(string)}");
            System.Console.WriteLine($"Default(decimal) = {default(decimal)}");
        
        }
    }
}
