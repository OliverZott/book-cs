using System;
using PrimeFactorsLib;
using System.Linq;

namespace PrimeFactorsProgramm
{
    class Program
    {
        static void Main(string[] args)
        {

            var divisors = PrimeFactorsCalculator.FindDivisors(26);

            // foreach (var i in divisors)
            // {
            //     System.Console.WriteLine(i);
            // }

            divisors.ToList().ForEach(i => Console.WriteLine(i));

            // why not working ???????
            //divisors.Select(i => Console.WriteLine($"i: {(int) i}"));
        }
    }
}
