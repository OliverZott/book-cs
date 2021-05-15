using System;
using System.Collections.Generic;

namespace Example.Shared
{
    public partial class Person
    {
        // old C# 1-5 notation
        public string Origin
        {
            get
            {
                return $"{Name} was born in {DateOfBirth}";
            }
        }



    }

}