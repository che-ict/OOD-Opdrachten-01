using NUnit.Framework;
using WinkelwagenEnProducten;

namespace WinkelwagenEnProductenTest
{
    public class Tests
    {
        [Test]
        public void TotaalPrijsWinkelwagen()
        {
            // Arrange
            var product1 = new Product { Naam = "Melk", Prijs = 2.50 };
            var product2 = new Product { Naam = "Brood", Prijs = 3.00 };
            var winkelwagen = new Winkelwagen();
            winkelwagen.Producten.Add(product1);
            winkelwagen.Producten.Add(product2);

            // Act
            var totaalPrijs = winkelwagen.GetTotaalPrijs();

            // Assert
            Assert.That(totaalPrijs, Is.EqualTo(5.50));
        }
    }
}
