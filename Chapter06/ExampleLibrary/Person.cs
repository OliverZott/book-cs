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

        public event EventHandler Shout;
        public int AngerLevel;

        // Event example
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                // Raise shout event  only if at least one event delegate pointing at a method.
                Shout?.Invoke(this, EventArgs.Empty);
            }
        }




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
            return Person.Procreate(p1, p1);
        }

        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{nameof(number)} cannot be less zero.");
            }

            return localFactorial(number);

            int localFactorial(int localNumber)
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }
    }
}
