using System;
using System.Collections.Generic;

namespace Example.Shared
{
    public partial class Person
    {
        private string favoritPrimaryColor;

        // Read-only properties (old C# 1-5 notation and modern lambda notation)
        public string Origin
        {
            get
            {
                return $"{Name} was born in {DateOfBirth}";
            }
        }
        public string Greeting => $"{Name} says 'Hello'.";
        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;

        // Seattable properties (without and with private property)
        public string FavoriteIceCream { get; set; }
        public string FavoritPrimaryColor
        {
            get
            {
                return favoritPrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritPrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException($"{value} is not a primary color (red, green, blue)!");
                }
            }
        }


    }

}