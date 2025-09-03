using Boeken;

namespace BoekenTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void BoekEigenschappen()
    {
        var boek = new Boek("A", "B", "C");
        Assert.Multiple(() =>
        {
            Assert.That(boek, Has.Property("Titel"));
            Assert.That(boek, Has.Property("Auteur"));
            Assert.That(boek, Has.Property("ISBN"));
            Assert.That(boek.GetType().GetProperty("Titel")?.PropertyType, Is.EqualTo(typeof(String)));
            Assert.That(boek.GetType().GetProperty("Auteur")?.PropertyType, Is.EqualTo(typeof(String)));
            Assert.That(boek.GetType().GetProperty("ISBN")?.PropertyType, Is.EqualTo(typeof(String)));
        });
    }

    [Test]
    public void BoekConstructor()
    {
        var boek = new Boek("The Hobbit", "J.R.R. Tolkien", "978-0-345-33968-3");
        Assert.Multiple(() =>
        {
            Assert.That(boek.Titel, Is.EqualTo("The Hobbit"));
            Assert.That(boek.Auteur, Is.EqualTo("J.R.R. Tolkien"));
            Assert.That(boek.ISBN, Is.EqualTo("978-0-345-33968-3"));
        });
    }

    [Test]
    public void BoekConstructorOverloaded()
    {
        var boek = new Boek("Mijn nieuwe boek", "David");
        Assert.Multiple(() =>
        {
            Assert.That(boek.Titel, "Mijn nieuwe boek");
            Assert.That(boek.Auteur, "David");
            Assert.That(boek.ISBN, "n.v.t.");
        });
    }
}