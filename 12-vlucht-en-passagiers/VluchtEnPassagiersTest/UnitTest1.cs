using NUnit.Framework;
using VluchtEnPassagiers;

namespace VluchtEnPassagiersTest
{
    public class Tests
    {
        [Test]
        public void PassagierToevoegenAanVlucht()
        {
            // Arrange
            var vlucht = new Vlucht { Vluchtnummer = "KL123" };
            var passagier = new Passagier { Naam = "John Smith" };

            // Act
            vlucht.Passagiers.Add(passagier);

            // Assert
            Assert.That(vlucht.Passagiers, Has.Count.EqualTo(1));
            Assert.That(vlucht.Passagiers[0], Is.EqualTo(passagier));
        }
    }
}
