namespace LijstenTest;

using Lijsten;

public class Tests
{
    
    List<string> baseList =  new List<string>()
    {
        "Scrooge",
        "Goofy",
        "Daisy",
        "Huey",
        "Louie",
        "Mickey",
        "Minnie"
    };
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestMetDonald()
    {
        var result = Lijsten.MetDonald(baseList);
        Assert.That(result, Contains.Item("Donald"));
    }
    
    [Test]
    public void TestMetTweeDonalds()
    {
        var result = Lijsten.MetDonald(baseList);
        result = Lijsten.MetDonald(baseList);
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
        var shuffledInput = baseList.OrderBy(x => random.Next()).ToList();
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
        var shuffledInput = baseList.OrderBy(x => random.Next()).ToList();
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
        var result = Lijsten.ZonderGoofy(baseList);
        Assert.Multiple(() =>
        {
            Assert.That(result, Has.Count.EqualTo(baseList.Count-1));
            Assert.That(result, Does.Not.Contain("Goofy"));
        });
    }

    [Test]
    public void TestZonderGoofyMult()
    {
        Random random = new Random();
        var input = new List<string>(baseList);
        for (int i = 0; i < random.Next()+1; i++)
        {
            input.Add("Goofy");
        }
        var result = Lijsten.ZonderGoofy(input);
        Assert.Multiple(() =>
        {
            Assert.That(result, Has.Count.EqualTo(baseList.Count-1));
            Assert.That(result, Does.Not.Contain("Goofy"));
        });
    }

    [Test]
    public void TestZonderE()
    {
        var expectedResult = new List<string>(){"Goofy", "Daisy"};
        var result = Lijsten.ZonderE(baseList); 
        Assert.That(result, Is.EquivalentTo(expectedResult));
    }
}

