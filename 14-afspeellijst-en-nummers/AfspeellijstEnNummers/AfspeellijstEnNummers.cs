using System.Collections.Generic;

namespace AfspeellijstEnNummers
{
    public class Nummer
    {
        public string Titel { get; set; }
        public string Artiest { get; set; }
    }

    public class Afspeellijst
    {
        public string Naam { get; set; }
        public List<Nummer> Nummers { get; } = new List<Nummer>();
    }
}
