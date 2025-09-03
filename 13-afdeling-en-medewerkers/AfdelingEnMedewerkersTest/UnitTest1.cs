using NUnit.Framework;
using AfdelingEnMedewerkers;

namespace AfdelingEnMedewerkersTest
{
    public class Tests
    {
        [Test]
        public void MedewerkerToevoegenAanAfdeling()
        {
            // Arrange
            var medewerker = new Medewerker { Naam = "Jane Doe" };
            var afdeling = new Afdeling { Naam = "HR" };

            // Act
            afdeling.Medewerkers.Add(medewerker);

            // Assert
            Assert.That(afdeling.Medewerkers.Count, Is.EqualTo(1));
            Assert.That(afdeling.Medewerkers[0], Is.EqualTo(medewerker));
        }
    }
}
