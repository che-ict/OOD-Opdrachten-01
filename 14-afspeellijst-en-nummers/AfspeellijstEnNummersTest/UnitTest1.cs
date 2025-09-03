using NUnit.Framework;
using AfspeellijstEnNummers;

namespace AfspeellijstEnNummersTest
{
    public class Tests
    {
        [Test]
        public void NummerToevoegenAanAfspeellijst()
        {
            // Arrange
            var nummer = new Nummer { Titel = "Bohemian Rhapsody", Artiest = "Queen" };
            var afspeellijst = new Afspeellijst { Naam = "Mijn Favorieten" };

            // Act
            afspeellijst.Nummers.Add(nummer);

            // Assert
            Assert.That(afspeellijst.Nummers.Count, Is.EqualTo(1));
            Assert.That(afspeellijst.Nummers[0], Is.EqualTo(nummer));
        }
    }
}
