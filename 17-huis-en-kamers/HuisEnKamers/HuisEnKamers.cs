using System.Collections.Generic;

namespace HuisEnKamers
{
    public class Kamer
    {
        public string Naam { get; }
        public Kamer(string naam) { Naam = naam; }
    }

    public class Huis
    {
        public List<Kamer> Kamers { get; } = new List<Kamer>();

        public Huis()
        {
            // TODO: implement
        }
    }
}
