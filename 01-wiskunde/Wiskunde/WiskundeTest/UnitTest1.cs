using Wiskunde;

namespace WiskundeTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestAddition()
    {
        var result = Operator.Optellen(10,2);
        Assert.That(result, Is.EqualTo(12));
    }

    [Test]
    public void TestSubtraction()
    {
        var result = Operator.Aftrekken(10,2);
        Assert.That(result, Is.EqualTo(8));
    }

    [Test]
    public void TestMultiply()
    {
        var result = Operator.Vermenigvuldigen(10,2);
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void TestDivisionRoundExact()
    {
        var result = Operator.Delen(10,2);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void TestDivisionRoundDown()
    {
        var result = Operator.Delen(10, 3);
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void TestDivisionRoundUp()
    {
        var result = Operator.Delen(5, 3);
        Assert.That(result, Is.EqualTo(1));
    }
}