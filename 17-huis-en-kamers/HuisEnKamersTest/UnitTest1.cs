using NUnit.Framework;
using HuisEnKamers;

namespace HuisEnKamersTest
{
    public class Tests
    {
        [Test]
        public void HuisHeeftKamersNaCreatie()
        {
            // Arrange
            var huis = new Huis();

            // Assert
            Assert.That(huis.Kamers.Count, Is.EqualTo(2));
            Assert.That(huis.Kamers[0].Naam, Is.EqualTo("Woonkamer"));
            Assert.That(huis.Kamers[1].Naam, Is.EqualTo("Keuken"));
        }
    }
}
