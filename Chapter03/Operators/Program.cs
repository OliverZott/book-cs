using System;
//using static System.Console;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // suffix / prefix operators
            int a = 4;
            int b = a++;

            Console.WriteLine($"a: {a} / b: {b}");

            // call by value
            int c = 10;
            int d = c;
            c += 12;
            System.Console.WriteLine($"c: {c} / d: {d}");

            // call by reference
            int[] arr = {1,2,3};
            int[] arr2 = arr;
            arr[1] = 42;
            System.Console.WriteLine(arr2[1]);;

            // division float / int
            System.Console.WriteLine($"7/2={7/2}; 7.0/2 ={7.0/2}"); 

            // Short-Circuit conditional operators
            static bool secondOperand() {
                Console.WriteLine("second operand evaluated");
                return true;
            }
            bool firstOperand = false;
            System.Console.WriteLine($"Evaluationg false & true: {firstOperand & secondOperand()}");
            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine($"Evaluationg false & true: {firstOperand && secondOperand()}");
            int[] wtf = {23, 11, 1};
            System.Console.WriteLine(sizeof(int));

            int age = 47;
            // How many operators in the following statement?
            char firstDigit = age.ToString()[0];
            // There are four operators:
            // = is the assignment operator
            // . is the member access operator
            // () is the invocation operator
            // [] is the indexer access operator

         }
    }
}
