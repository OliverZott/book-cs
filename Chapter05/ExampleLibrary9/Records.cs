using System;

namespace ExampleLibrary9
{
    public class ImmutablePerson
    {
        // private readonly string str;

        public string FirstName { get; init; }
        public string LastName { get; init; }

    }

    public record ImmutableVehicle
    {
        public int Wheels { get; init; }
        public string Color { get; init; }
        public string Brand { get; init; }
    }

    public record ImmutableAnimal
    {
        string Name;  // i.e. public init-only property
        string Species;

        public ImmutableAnimal(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public void Deconstruct(out string name, out string species)
        {
            name = Name;
            species = Species;
        }
    }

    // ALternative not working! (page 180)
    //public data class ImmutableAnimal2(string Name, string Species);

}