using System.Collections.Generic;
using System.Linq;

namespace WinkelwagenEnProducten
{
    public class Product
    {
        public string Naam { get; set; }
        public double Prijs { get; set; }
    }

    public class Winkelwagen
    {
        public List<Product> Producten { get; } = new List<Product>();
    
        public double GetTotaalPrijs()
        {
            // TODO: implement
            return 0;
        }
    }
}
