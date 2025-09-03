namespace PersoonEnBSN
{
    public class BSN
    {
        public string Nummer { get; }
        public BSN(string nummer) { Nummer = nummer; }
    }

    public class Persoon
    {
        public string Naam { get; }
        public BSN PersoonsBSN { get; }

        public Persoon(string naam, string bsnNummer)
        {
            Naam = naam;
            // TODO: implement
        }
    }
}
