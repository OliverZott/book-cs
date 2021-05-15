using System;
using System.Collections.Generic;

namespace Example.Shared
{
    public partial class Person : object
    {
        // read-only better  than const (page 156)
        public static readonly string HomePlanet = "Earth";
        public readonly DateTime InstantiatedAt;

        public const string Species = "Homo Sapiens";

        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld favoriteWonder;

        public List<Person> Children = new();


        public Person(string name, DateTime dateOfBirth) : this(name)
        {
            this.DateOfBirth = dateOfBirth;
        }
        public Person(string name) : this()
        {
            this.Name = name;
        }
        public Person()
        {
            Name = "Unknown";
            InstantiatedAt = DateTime.Now;
        }


        public override string ToString()
        {
            return base.ToString() + ", Name: " + this.Name + ", instantiated at " + this.InstantiatedAt;
        }
        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }
        public (string Name, int Numbers) GetNamedFruit()
        {
            return (Name: "Bananaaaa", Numbers: 7);
        }
        public string SayHello()
        {
            return $"{Name} says Hello";
        }
        public string SayHello(string name)
        {
            return $"{Name} says hello to {name}.";
        }
        public void PassingParameters(int a, ref int b, out int c)
        {
            c = 99;
            a++;
            b++;
            c++;
        }



    }
}
