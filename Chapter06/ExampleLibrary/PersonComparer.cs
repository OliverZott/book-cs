using System.Collections.Generic;

namespace ExampleLibrary
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var lengthCompareResult = x.Name.Length.CompareTo(y.Name.Length);

            if (lengthCompareResult == 0)
            {
                return x.Name.CompareTo(y.Name);  // standard string-compare method.
            }
            else
            {
                return lengthCompareResult;
            }
        }
    }
}