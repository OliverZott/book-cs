#nullable enable
using System;

namespace NullHandling
{

    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // default for string is null, because string is reference type
            var k = default(string);
            System.Console.WriteLine(default(bool));
            System.Console.WriteLine(k);
            System.Console.WriteLine(default(int));
            System.Console.WriteLine(default(decimal));

            var address = new Address();
            address.Building = null;


            System.Console.WriteLine("string ... = default: " + address.Street);

            //address.Street = null;
            address.City = "London";

            var buildingNameLenght = address.Building?.Length ?? 42;
            System.Console.WriteLine($"Building name length: {buildingNameLenght}");





            // int thisCannotBeNull = null;
            int? thisCanBeNull = null;
            //Console.WriteLine($"Nullable value: {thisCanBeNull}, Type: {thisCanBeNull.GetType()}");
            Console.WriteLine($"Nullable value:    {thisCanBeNull}, Type: {thisCanBeNull.GetValueOrDefault()}");

            thisCanBeNull = 7;
            //Console.WriteLine($"Nullable value: {thisCanBeNull}, Type: {thisCanBeNull.GetType()}");
            Console.WriteLine($"Nullable value: {thisCanBeNull}, Type: {thisCanBeNull.GetValueOrDefault()}");

        }
    }
}
