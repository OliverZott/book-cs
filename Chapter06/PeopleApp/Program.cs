﻿using System;
using ExampleLibrary;
using static System.Console;

namespace PeopleApp
{
    class Program
    {



        // --------------- Event Examples ---------------
        // private static void Harry_Shout(object sender, EventArgs e)
        // {
        //     Person p = (Person)sender;
        //     System.Console.WriteLine($"{p.Name} is angry level {p.AngerLevel}");
        // }
        // private static void Harry_Shout2(object sender, EventArgs e)
        // {
        //     System.Console.WriteLine($"Blub");
        // }


        static void Main()
        {
            // --------------- Generics Examples ---------------
            var t1 = new Thing();
            t1.Data = 42;
            System.Console.WriteLine(t1.Process(42));

            var t2 = new Thing();
            t2.Data = "blub";
            System.Console.WriteLine(t1.Process("blub"));

            var gt1 = new GenericThing<int>();
            gt1.Data = 42;
            System.Console.WriteLine(gt1.Process(42));

            var gt2 = new GenericThing<string>();
            gt2.Data = "blub";
            System.Console.WriteLine(gt2.Process("blub"));

            byte number = (byte)3;
            System.Console.WriteLine(Squarer.Square(number));



            // --------------- Interfaces Examples ---------------
            // Person[] people =
            // {
            //     new Person{ Name = "Olli"},
            //     new Person{ Name = "Lena"},
            //     new Person{ Name = "Zwu"},
            //     new Person{ Name = "Sigi"}
            // };

            // Array.Sort(people);
            // foreach (var person in people)
            // {
            //     WriteLine(person.Name);
            // }

            // Array.Sort(people, new PersonComparer());
            // foreach (var person in people)
            // {
            //     WriteLine(person.Name);
            // }


            // --------------- Event Examples ---------------
            //     var harry = new Person { Name = "Harry" };
            //     harry.Shout += Harry_Shout;
            //     harry.Shout += Harry_Shout2;
            //     harry.Poke();
            //     harry.Poke();
            //     harry.Poke();
            //     harry.Poke();
            //     harry.Poke();


            // var res = Person.Factorial(3);
            // System.Console.WriteLine(res);


            // Person Olli = new Person { Name = "Olli", DateOfBirth = new DateTime(1983, 12, 17) };
            // Person Lena = new Person { Name = "Lena", DateOfBirth = new DateTime(1986, 09, 07) };
            // var zwu = Person.Procreate(Olli, Lena);
            // var zwu2 = Olli * Lena;
            // System.Console.WriteLine($"{Olli.Children.Count} children: {zwu.Name} and {zwu2.Name}");
        }
    }
}