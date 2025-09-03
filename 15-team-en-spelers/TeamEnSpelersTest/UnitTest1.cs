using NUnit.Framework;
using TeamEnSpelers;

namespace TeamEnSpelersTest
{
    public class Tests
    {
        [Test]
        public void SpelerToevoegenAanTeam()
        {
            // Arrange
            var speler = new Speler { Naam = "Lionel Messi" };
            var team = new Team { Naam = "FC Barcelona" };

            // Act
            team.Spelers.Add(speler);

            // Assert
            Assert.That(team.Spelers.Count, Is.EqualTo(1));
            Assert.That(team.Spelers[0], Is.EqualTo(speler));
        }
    }
}
