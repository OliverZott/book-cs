using System;
using Example.Shared;
using ExampleLibrary;
using ExampleLibrary9;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Olli = new("Olli", new DateTime(1983, 12, 17));

            // ------------------------ page 180 - Record short version ------------------------ 
            var kosto = new ImmutableAnimal("Kosto", "Cat");
            var (name, species) = kosto;
            System.Console.WriteLine($"{name} is a {species}.");



            // ------------------------ page 179 - Init / Records ------------------------ 
            var Lenchen = new ImmutablePerson
            {
                FirstName = "Magdalena",
                LastName = "Bergmann"
            };

            var car = new ImmutableVehicle
            {
                Wheels = 4,
                Brand = "Ford",
                Color = "Blue",
            };

            var repaintedCar = car with { Color = "Black" };
            // repaintedCar.Color = "Green";

            System.Console.WriteLine($"Original color was {car.Color}, repainted color is {repaintedCar.Color}.");
            


            // ------------------------ page 176 - Pattern Matching ------------------------ 
            /*
            object[] passengers = {
                new FirstClassPassenger(){ AirMiles = 1_415},
                new FirstClassPassenger{ AirMiles = 16_562},
                new CoachClassPassenger{ CarryOnKG = 25.3},
                new CoachClassPassenger{ CarryOnKG = 0.3},
                new BusinessClassPassenger(),
            };

            foreach (object passenger in passengers)
            {
                decimal fligthCost = passenger switch
                {
                    FirstClassPassenger p => p.AirMiles switch
                    {
                        > 35000 => 1500M,
                        > 15000 => 1750M,
                        _ => 2000M,
                    },

                    BusinessClassPassenger => 1000M,

                    CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
                    CoachClassPassenger => 650M,
                    _ => 800M,
                };

                System.Console.WriteLine($"Flight costs {fligthCost:C} for {passenger}");
            }
            //*/



            // ------------------------ page 172 - Properties and Indexers ------------------------ 
            /*
            System.Console.WriteLine(Olli.Origin);
            System.Console.WriteLine(Olli.Age);
            try
            {
                Olli.FavoritPrimaryColor = "yello";

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            System.Console.WriteLine(Olli.FavoritPrimaryColor);

            Olli.Children.Add(new Person("child1"));
            Olli.Children.Add(new Person("child2"));
            Olli.Children.Add(new Person("child3"));
            System.Console.WriteLine(Olli.Children[4]);
            */



            // ------------------------ page 167 - parameter passing ------------------------ 
            /*
            int a = 10;
            int b = 20;
            int c = 30;
            System.Console.WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            Olli.PassingParameters(a, ref b, out c);
            System.Console.WriteLine($"After: a = {a}, b = {b}, c = {c}");
            */



            // ------------------------ page 165 - method overloading ------------------------ 
            // System.Console.WriteLine(Olli.SayHello("Lena"));


            // ------------------------ page 162 - tuple / deconstruct tuple ------------------------
            (string, int) fruits = Olli.GetFruit();
            /*
            System.Console.WriteLine($"There are {fruits.Item2} {fruits.Item1} ");
            // Deconstruct tuple
            (string fruit, int amount) = Olli.GetFruit();
            System.Console.WriteLine($"{fruit}, {amount}");

            var fruitNamed = Olli.GetNamedFruit();
            System.Console.WriteLine($"There are {fruitNamed.Numbers} {fruitNamed.Name}");
            */



            // ------------------------ page 158 - default ------------------------
            ThingOfDefaults defaultThing = new();
            //System.Console.WriteLine(defaultThing);



            // ------------------------ page 157 - constructor ------------------------
            Person Sigi = new("Sigi", new DateTime(2018, 09, 07));
            //System.Console.WriteLine(Sigi.ToString());



            // ------------------------ page 156 - const / read-only ------------------------
            //System.Console.WriteLine($"{Olli.Name} is a {Person.Species}");



            // ------------------------ page 155 - static ------------------------
            BankAccount.InterestRate = 0.012M;

            var lenasAccount = new BankAccount();
            lenasAccount.accountName = "Lenas Account";
            lenasAccount.Balance = 5500;
            //System.Console.WriteLine(format: "{0} earned {1:C} interest.", arg0: lenasAccount.accountName, arg1: lenasAccount.Balance * BankAccount.InterestRate);



            // ------------------------ page 150 - basics ------------------------    
            Person Lena = new();
            Lena.Name = "Lena";
            Lena.favoriteWonder = WondersOfTheAncientWorld.LighthouseOfAlexandria;
            Lena.DateOfBirth = new DateTime(1986, 09, 07);

            Person Sigggi = new Person { Name = "Sigi", DateOfBirth = new DateTime(2019, 12, 24), favoriteWonder = (WondersOfTheAncientWorld).3 };

            Lena.Children.Add(new Person { Name = "child1" });
            Lena.Children.Add(new Person() { Name = "child2" });

            /*
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

            foreach (var child in Lena.children) {
                System.Console.WriteLine(child.name);
            }
            */
        }

    }
}
