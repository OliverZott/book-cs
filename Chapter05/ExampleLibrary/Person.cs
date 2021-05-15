using System;
using System.Collections.Generic;

namespace Example.Shared
{
    public class Person : object
    {
        // read-only better  than const (page 156)
        public static readonly string HomePlanet = "Earth";
        public readonly DateTime InstantiatedAt;

        public const string Species = "Homo Sapiens";

        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld favoriteWonder;

        public List<Person> children = new();


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

    }
}
