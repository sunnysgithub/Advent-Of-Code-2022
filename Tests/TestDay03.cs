using AdventOfCode;

namespace Tests;

public class TestDay03
{
    [Test]
    [TestCase(@"../../../Files/03ExampleInput.txt", 157)]
    [TestCase(@"../../../Files/03Input.txt", 0)]
    public void Test_Day03_Solve(
        string path,
        int result
        )
    {
        Assert.That(Day03.Solve(path), Is.EqualTo(result));
    }

    [Test]
    public void Test_ToPriority()
    {
        Assert.That('a'.ToPriority(), Is.EqualTo(1));
        Assert.That('z'.ToPriority(), Is.EqualTo(26));
        Assert.That('A'.ToPriority(), Is.EqualTo(27));
        Assert.That('Z'.ToPriority(), Is.EqualTo(52));
    }

    [Test]
    public void Test_CompareCompartments()
    {
        Assert.That("ab".CompareCompartments(), Is.EqualTo(0));
    }
}

