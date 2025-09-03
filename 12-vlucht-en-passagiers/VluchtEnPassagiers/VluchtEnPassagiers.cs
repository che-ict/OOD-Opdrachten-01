using System.Collections.Generic;

namespace VluchtEnPassagiers
{
    public class Passagier
    {
        public string Naam { get; set; }
    }

    public class Vlucht
    {
        public string Vluchtnummer { get; set; }
        public List<Passagier> Passagiers { get; } = new List<Passagier>();
    }
}
