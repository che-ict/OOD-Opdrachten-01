using NUnit.Framework;
using ArtsenEnPatienten;
using System.Linq;

namespace ArtsenEnPatientenTest
{
    public class Tests
    {
        [Test]
        public void WijsPatientToeAanArts()
        {
            // Arrange
            var arts1 = new Arts { Naam = "Dr. House" };
            var patient1 = new Patient { Naam = "Jane Doe" };

            // Act
            arts1.VoegPatientToe(patient1);

            // Assert
            Assert.That(arts1.Patienten.Contains(patient1), Is.True);
            Assert.That(patient1.Artsen.Contains(arts1), Is.True);
        }
        
        [Test]
        public void WijsArtsToeAanPatient()
        {
            // Arrange
            var arts1 = new Arts { Naam = "Dr. Phil" };
            var patient1 = new Patient { Naam = "Bhad Bhabie" };

            // Act
            patient1.VoegArtsToe(arts1);

            // Assert
            Assert.That(arts1.Patienten.Contains(patient1), Is.True);
            Assert.That(patient1.Artsen.Contains(arts1), Is.True);
        }
    }
}
