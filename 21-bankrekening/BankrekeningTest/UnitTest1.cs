using NUnit.Framework;
using Bankrekening;

namespace BankrekeningTest
{
    public class Tests
    {
        [Test]
        public void StortBedrag_VerhoogtSaldo()
        {
            // Arrange
            var rekening = new Bankrekening(100);

            // Act
            rekening.Stort(50);

            // Assert
            Assert.That(rekening.GetSaldo(), Is.EqualTo(150));
        }

        [Test]
        public void NeemOpBedrag_VerlaagtSaldo()
        {
            // Arrange
            var rekening = new Bankrekening(100);

            // Act
            var succes = rekening.NeemOp(50);

            // Assert
            Assert.That(succes, Is.True);
            Assert.That(rekening.GetSaldo(), Is.EqualTo(50));
        }

        [Test]
        public void NeemOpBedrag_OnvoldoendeSaldo_Faalt()
        {
            // Arrange
            var rekening = new Bankrekening(100);

            // Act
            var succes = rekening.NeemOp(150);

            // Assert
            Assert.That(succes, Is.False);
            Assert.That(rekening.GetSaldo(), Is.EqualTo(100));
        }

        [Test]
        public void StortNegatiefBedrag_DoetNiets()
        {
            // Arrange
            var rekening = new Bankrekening(100);

            // Act
            rekening.Stort(-50);

            // Assert
            Assert.That(rekening.GetSaldo(), Is.EqualTo(100));
        }

        [Test]
        public void NeemOpNegatiefBedrag_DoetNiets()
        {
            // Arrange
            var rekening = new Bankrekening(100);

            // Act
            var succes = rekening.NeemOp(-50);

            // Assert
            Assert.That(succes, Is.False);
            Assert.That(rekening.GetSaldo(), Is.EqualTo(100));
        }
    }
}
