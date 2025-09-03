using System.Collections.Generic;

namespace TeamEnSpelers
{
    public class Speler
    {
        public string Naam { get; set; }
    }

    public class Team
    {
        public string Naam { get; set; }
        public List<Speler> Spelers { get; } = new List<Speler>();
    }
}
