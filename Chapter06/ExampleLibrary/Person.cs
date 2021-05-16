using System;
using System.Collections.Generic;

#nullable disable

namespace ExampleLibrary
{
    public class Person
    {
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new();

        public void WriteToConsole()
        {
            System.Console.WriteLine($"{Name} was born in {DateOfBirth}.");
        }

        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person() { Name = $"Baby of {p1.Name} and {p2.Name}." };
            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
        }

        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        public static Person operator *(Person p1, Person p2)
        {
            return Procreate(p1, p1);
        }
    }
}
