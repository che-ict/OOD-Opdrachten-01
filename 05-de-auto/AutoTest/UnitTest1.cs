namespace AutoTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AutoHeeftEigenschappenTest()
    {
        var auto = new Auto.Auto("A", "B", 2000);
        Assert.Multiple(() =>
        {
            Assert.That(auto, Has.Property("Merk"));
            Assert.That(auto.GetType().GetProperty("Merk")?.PropertyType, Is.EqualTo(typeof(String)));
            Assert.That(auto, Has.Property("Model"));
            Assert.That(auto.GetType().GetProperty("Model")?.PropertyType, Is.EqualTo(typeof(String)));
            Assert.That(auto, Has.Property("Bouwjaar"));
            Assert.That(auto.GetType().GetProperty("Bouwjaar")?.PropertyType, Is.EqualTo(typeof(int)));
        });
    }

    [Test]
    public void AutoInfoTest()
    {
        var auto = new Auto.Auto();
        auto.Merk = "Hyundai";
        auto.Model = "Atos";
        auto.Bouwjaar = 2002;
        
        Assert.That(auto.AutoInfo(), Is.EqualTo("Merk: Hyundai, Model: Atos, Bouwjaar: 2002"));
    }

    [Test]
    public void AutoConstructorTest()
    {
        var auto = new Auto.Auto("Dacia", "Stepway", 2017);
        Assert.That(auto.AutoInfo(), Is.EqualTo("Merk: Dacia, Model: Stepway, Bouwjaar: 2017"));
    }
}