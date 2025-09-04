using System.Collections.Immutable;

namespace LijstenTest;

using Lijsten;

public class Tests
{
    readonly ImmutableList<string> _baseList =  new List<string>()
    {
        "Scrooge",
        "Goofy",
        "Daisy",
        "Huey",
        "Louie",
        "Mickey",
        "Minnie"
    }.ToImmutableList();
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestMetDonald()
    {
        var result = Lijsten.MetDonald(_baseList.ToList());
        Assert.That(result, Contains.Item("Donald"));
    }
    
    [Test]
    public void TestMetTweeDonalds()
    {
        var result = Lijsten.MetDonald(_baseList.ToList());
        result = Lijsten.MetDonald(result.ToList());
        var filteredResult = result.Where(x => x == "Donald").ToList();
        Assert.Multiple(() =>
        {
            Assert.That(result, Contains.Item("Donald"));
            Assert.That(filteredResult, Has.Count.EqualTo(2));
        });
    }

    [Test]
    public void TestEersteDrie()
    {
        Random random = new Random();
        var shuffledInput = _baseList.OrderBy(_ => random.Next()).ToList();
        var result = Lijsten.EersteDrie(shuffledInput);
        Assert.Multiple(() =>
        {
            Assert.That(result, Contains.Item(shuffledInput[0]));
            Assert.That(result, Contains.Item(shuffledInput[1]));
            Assert.That(result, Contains.Item(shuffledInput[2]));
            Assert.That(result, Has.Count.EqualTo(3));
        });
    }

    [Test]
    public void TestLaatsteDrie()
    {
        Random random = new Random();
        var shuffledInput = _baseList.OrderBy(_ => random.Next()).ToList();
        var result = Lijsten.LaatsteDrie(shuffledInput);
        Assert.Multiple(() =>
        {
            Assert.That(result, Contains.Item(shuffledInput[^1]));
            Assert.That(result, Contains.Item(shuffledInput[^2]));
            Assert.That(result, Contains.Item(shuffledInput[^3]));
            Assert.That(result, Has.Count.EqualTo(3));
        });
    }

    [Test]
    public void TestZonderGoofy()
    {
        var result = Lijsten.ZonderGoofy(_baseList.ToList());
        Assert.Multiple(() =>
        {
            Assert.That(result, Has.Count.EqualTo(_baseList.Count-1));
            Assert.That(result, Does.Not.Contain("Goofy"));
        });
    }

    [Test]
    public void TestZonderGoofyMult()
    {
        Random random = new Random();
        var input = new List<string>(_baseList);
        for (int i = 0; i < random.Next()+1; i++)
        {
            input.Add("Goofy");
        }
        var result = Lijsten.ZonderGoofy(input);
        Assert.Multiple(() =>
        {
            Assert.That(result, Has.Count.EqualTo(_baseList.Count-1));
            Assert.That(result, Does.Not.Contain("Goofy"));
        });
    }

    [Test]
    public void TestZonderE()
    {
        var expectedResult = new List<string>(){"Goofy", "Daisy"};
        var result = Lijsten.ZonderE(_baseList.ToList()); 
        Assert.That(result, Is.EquivalentTo(expectedResult));
    }
}