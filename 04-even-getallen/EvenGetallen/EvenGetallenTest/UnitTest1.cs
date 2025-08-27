namespace EvenGetallenTest;

using EvenGetallen;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestGeefEvenGetallenTien()
    {
        var expectedResult = new List<int> { 2, 4, 6, 8, 10 };
        var result = EvenGetallen.GeefEvenGetallen(10);
        Assert.That(result, Is.EquivalentTo(expectedResult));;
    }

    [Test]
    public void TestGeefEvenGetallenElf()
    {
        var expectedResult = new List<int> { 2, 4, 6, 8, 10 };
        var result = EvenGetallen.GeefEvenGetallen(11);
        Assert.That(result, Is.EquivalentTo(expectedResult));
    }

    [Test]
    public void TestGeefEvenGetallenTwee()
    {
        var expectedResult = new List<int> { 2 };
        var result = EvenGetallen.GeefEvenGetallen(2);
        Assert.That(result, Is.EquivalentTo(expectedResult));
    }

    [Test]
    public void TestGeefEvenGetallenNegatief()
    {
        var expectedResult = new List<int>();
        var result = EvenGetallen.GeefEvenGetallen(-1);
        Assert.That(result, Is.EquivalentTo(expectedResult));   
    }
    
    [Test]
    public void TestEvenGetallenReeks()
    {
        var expectedResult = new List<int> { 4, 6, 8, 10 };
        var result = EvenGetallen.GeefEvenGetallenInReeks(4, 10);
        Assert.That(result, Is.EquivalentTo(expectedResult));  
    }
    
    [Test]
    public void TestEvenGetallenReeksNegatief()
    {
        var expectedResult = new List<int> { -4, -2, 0, 2, 4 };
        var result = EvenGetallen.GeefEvenGetallenInReeks(-4, 4);
        Assert.That(result, Is.EquivalentTo(expectedResult));
    }
    
    [Test]
    public void TestAantalEvenGetallen()
    {
        var expectedResult = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };
        var result = EvenGetallen.GeefAantalEvenGetallen(8);
        Assert.That(result, Is.EquivalentTo(expectedResult)); 
    }
}