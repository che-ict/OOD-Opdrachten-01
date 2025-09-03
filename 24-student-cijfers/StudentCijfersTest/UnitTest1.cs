using NUnit.Framework;
using StudentCijfers;
using System.Linq;

namespace StudentCijfersTest
{
    public class Tests
    {
        [Test]
        public void CijferWordtToegevoegdEnGemiddeldeIsCorrect()
        {
            // Arrange
            var student = new Student();

            // Act
            student.VoegCijferToe(8.5);
            student.VoegCijferToe(9.0);

            // Assert
            Assert.That(student.GetGemiddeldCijfer(), Is.EqualTo(8.75));
        }

        [Test]
        public void OngeldigCijferWordtNietToegevoegd()
        {
            // Arrange
            var student = new Student();

            // Act
            student.VoegCijferToe(8.0);
            student.VoegCijferToe(11.0); // Invalid
            student.VoegCijferToe(-1.0); // Invalid

            // Assert
            Assert.That(student.GetGemiddeldCijfer(), Is.EqualTo(8.0));
        }

        [Test]
        public void GemiddeldeVanLegeLijstIsNul()
        {
            // Arrange
            var student = new Student();

            // Act
            var gemiddelde = student.GetGemiddeldCijfer();

            // Assert
            Assert.That(gemiddelde, Is.EqualTo(0));
        }
    }
}
