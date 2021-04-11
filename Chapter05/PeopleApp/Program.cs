using System;
using Example.Shared;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Person Lena = new();
            Lena.name = "Lena";
            Lena.favoriteWonder = WondersOfTheAncientWorld.LighthouseOfAlexandria;
            Lena.dateOfBirth = new DateTime(1986, 09, 07);

            Person Sigi = new Person { name = "Sigi", dateOfBirth = new DateTime(2019, 12, 24), favoriteWonder = (WondersOfTheAncientWorld).3 };

            Console.WriteLine(
                format: "{0} was born on {1:dddd, d MMMM yyyy} and likes {2} (int of wonder: ). ",
                arg0: Lena.name,
                arg1: Lena.dateOfBirth,
                arg2: Lena.favoriteWonder);

            Console.WriteLine(
                format: "{0} came to us on {1: dd MMM yy} and likes {2}",
                arg0: Sigi.name,
                arg1: Sigi.dateOfBirth,
                arg2: Sigi.favoriteWonder);
        }
    }
}
