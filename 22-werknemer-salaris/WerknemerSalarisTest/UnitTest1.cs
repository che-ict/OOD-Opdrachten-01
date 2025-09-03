using NUnit.Framework;
using WerknemerSalaris;

namespace WerknemerSalarisTest
{
    public class Tests
    {
        [Test]
        public void InitieelSalarisWordtCorrectIngesteld()
        {
            // Arrange & Act
            var werknemer = new Werknemer(50000);

            // Assert
            Assert.That(werknemer.GetSalaris(), Is.EqualTo(50000));
        }

        [Test]
        public void SalarisKanWordenAangepast()
        {
            // Arrange
            var werknemer = new Werknemer(50000);

            // Act
            werknemer.SetSalaris(60000);

            // Assert
            Assert.That(werknemer.GetSalaris(), Is.EqualTo(60000));
        }

        [Test]
        public void SalarisKanNietNegatiefZijn()
        {
            // Arrange
            var werknemer = new Werknemer(60000);

            // Act
            werknemer.SetSalaris(-1000);

            // Assert
            Assert.That(werknemer.GetSalaris(), Is.EqualTo(60000));
        }
    }
}
