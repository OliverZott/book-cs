using System;
using ExampleLibrary;

namespace PeopleApp
{
    class Program
    {
        static void Main()
        {
            Person Olli = new Person { Name = "Olli", DateOfBirth = new DateTime(1983, 12, 17) };
            Person Lena = new Person { Name = "Lena", DateOfBirth = new DateTime(1986, 09, 07) };
            var zwu = Person.Procreate(Olli, Lena);
            var zwu2 = Olli * Lena;
            System.Console.WriteLine($"{Olli.Children.Count} children: {zwu.Name} and {zwu2.Name}");
        }
    }
}
