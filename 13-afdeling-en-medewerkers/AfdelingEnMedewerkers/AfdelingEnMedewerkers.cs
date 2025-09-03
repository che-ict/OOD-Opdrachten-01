using System.Collections.Generic;

namespace AfdelingEnMedewerkers
{
    public class Medewerker
    {
        public string Naam { get; set; }
    }

    public class Afdeling
    {
        public string Naam { get; set; }
        public List<Medewerker> Medewerkers { get; } = new List<Medewerker>();
    }
}
