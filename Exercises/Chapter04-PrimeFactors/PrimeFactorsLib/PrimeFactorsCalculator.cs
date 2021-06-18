using System;
using System.Collections.Generic;

namespace PrimeFactorsLib
{
    public class PrimeFactorsCalculator
    {

        // for or while?
        // use finale for list?
        // how use linq / lambdas  ?!?!?!
        public static List<int> FindDivisors(int value)
        {
            var divisorList = new List<int>();

            int i = 1;
            while (i <= value / 2)
            {
                if (value % i == 0)
                {
                    divisorList.Add(i);
                }
                i++;
            }

            return divisorList;
        }

        public static string PrimeFactors(int value)
        {
            var x = 2;
            return $"Prime factors are {x}.";
        }
    }
}
