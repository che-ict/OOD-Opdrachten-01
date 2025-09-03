namespace RechthoekTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void RechthoekEigenschappen()
    {
        var rechthoek = new Rechthoek.Rechthoek(5,6);
        Assert.Multiple(() =>
        {
            Assert.That(rechthoek, Has.Property("Lengte"));
            Assert.That(rechthoek, Has.Property("Breedte"));
            Assert.That(rechthoek.GetType().GetProperty("Breedte")?.PropertyType, Is.EqualTo(typeof(int)));
            Assert.That(rechthoek.GetType().GetProperty("Lengte")?.PropertyType, Is.EqualTo(typeof(int)));
        });
        
    }

    [Test]
    public void RechthoekOppervlak()
    {
        var rechthoek = new Rechthoek.Rechthoek(10,2);
        var oppervlakte = rechthoek.Oppervlakte();
        var expected = 20;
        Assert.That(oppervlakte, Is.EqualTo(expected));
    }

    [Test]
    public void RechthoekOmtrek()
    {
        var rechthoek = new Rechthoek.Rechthoek(4, 7);
        var omtrek = rechthoek.Omtrek();
        var expected = 22;
        Assert.That(omtrek, Is.EqualTo(expected));
    }
}