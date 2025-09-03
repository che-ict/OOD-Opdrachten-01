using NUnit.Framework;
using PersoonEnBSN;
using System.Reflection;

namespace PersoonEnBSNTest
{
    public class Tests
    {
        [Test]
        public void PersoonHeeftBSNNaCreatie()
        {
            // Arrange
            var persoon = new Persoon("Jan", "123456789");

            // Assert
            Assert.That(persoon.PersoonsBSN, Is.Not.Null);
            Assert.That(persoon.PersoonsBSN.Nummer, Is.EqualTo("123456789"));
        }

        [Test]
        public void PersoonsBSNPropertyIsReadOnly()
        {
            // Arrange
            Type persoonType = typeof(Persoon);
            PropertyInfo persoonsBSNProperty = persoonType.GetProperty("PersoonsBSN");

            // Assert
            Assert.That(persoonsBSNProperty, Is.Not.Null, "PersoonsBSN property not found.");
            Assert.That(persoonsBSNProperty.CanWrite, Is.False, "PersoonsBSN property should not have a public setter.");
        }

        [Test]
        public void BSNNummerPropertyIsReadOnly()
        {
            // Arrange
            Type bsnType = typeof(BSN);
            PropertyInfo nummerProperty = bsnType.GetProperty("Nummer");

            // Assert
            Assert.That(nummerProperty, Is.Not.Null, "Nummer property not found in BSN class.");
            Assert.That(nummerProperty.CanWrite, Is.False, "Nummer property in BSN class should not have a public setter.");
        }
    }
}
