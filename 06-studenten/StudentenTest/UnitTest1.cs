using Studenten;

namespace StudentenTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void StudentEigenschappen()
    {
        var student = new Student("Jantje", 22, 50);
        Assert.Multiple(() =>
        {
            Assert.That(student, Has.Property("Naam"));
            Assert.That(student, Has.Property("Leeftijd"));
            Assert.That(student, Has.Property("Studiepunten"));
            Assert.That(student.GetType().GetProperty("Naam")?.PropertyType, Is.EqualTo(typeof(String)));
            Assert.That(student.GetType().GetProperty("Leeftijd")?.PropertyType, Is.EqualTo(typeof(int)));
            Assert.That(student.GetType().GetProperty("Studiepunten")?.PropertyType, Is.EqualTo(typeof(int)));
        });
    }

    [Test]
    public void TestHeeftBSA20()
    {
        var student = new Student();
        student.Studiepunten = 20;
        Assert.That(student.HeeftBSA(), Is.EqualTo(false));
    }
    
    [Test]
    public void TestHeeftBSA40()
    {
        var student = new Student();
        student.Studiepunten = 40;
        Assert.That(student.HeeftBSA(), Is.EqualTo(true));
    }
    
    [Test]
    public void TestHeeftBSA50()
    {
        var student = new Student();
        student.Studiepunten = 50;
        Assert.That(student.HeeftBSA(), Is.EqualTo(true));
    }

    [Test]
    public void TestHeeftProp50()
    {
        var student = new Student();
        student.Studiepunten = 50;
        Assert.That(student.HeeftPropedeuse(), Is.EqualTo(false));
    }
    
    [Test]
    public void TestHeeftProp60()
    {
        var student = new Student();
        student.Studiepunten = 60;
        Assert.That(student.HeeftPropedeuse(), Is.EqualTo(true));
    }
    
    [Test]
    public void TestHeeftProp75()
    {
        var student = new Student();
        student.Studiepunten = 75;
        Assert.That(student.HeeftPropedeuse(), Is.EqualTo(true));
    }
}