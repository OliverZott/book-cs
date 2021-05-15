using System;
using System.Collections.Generic;
using Example.Shared;

namespace ExampleLibrary
{
    public class ThingOfDefaults
    {
        public int Population;
        public DateTime When;
        public string Name;
        public List<Person> People;

        public ThingOfDefaults()
        {
            Population = default;
            Name = default;
            When = default;
            People = default;
        }

        public override string ToString()
        {
            return base.ToString() + $"; Name: {Name}, When: {When}, Population: {Population}, PeopleList: {People}";
        }
    }
}