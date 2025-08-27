using Namen;

namespace NamenTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestNormaleNaam()
    {
        string result = NamenBouwer.SimpeleNaam("Jip", "Jansen");
        Assert.That(result, Is.EqualTo("Jip Jansen"));
    }

    [Test]
    public void TestTussenVoegsel()
    {
        string result = NamenBouwer.NaamMetTussenVoegsel("Jip", "de", "Kip");
        Assert.That(result, Is.EqualTo("Jip de Kip"));
    }

    [Test]
    public void TestTussenVoegselZonderTusenVoegsel()
    {
        string result = NamenBouwer.NaamMetTussenVoegsel("Jip", "", "Jansen");
        Assert.That(result, Is.EqualTo("Jip Jansen"));
    }
}