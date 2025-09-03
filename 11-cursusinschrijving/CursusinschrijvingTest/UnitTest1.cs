using NUnit.Framework;
using Cursusinschrijving;

namespace CursusinschrijvingTest
{
    public class Tests
    {
        [Test]
        public void StudentSchrijftInVoorCursus()
        {
            // Arrange
            var student = new Student { Naam = "Alice" };
            var cursus = new Cursus { CursusNaam = "OOD" };

            // Act
            student.SchrijfIn(cursus);

            // Assert
            Assert.That(student.Cursussen, Has.Count.EqualTo(1));
            Assert.That(student.Cursussen[0], Is.EqualTo(cursus));
        }
    }
}
