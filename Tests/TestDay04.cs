using AdventOfCode;

namespace Tests;

public class TestDay04
{
    [Test]
    [TestCase(@"../../../Files/04ExampleInput.txt", 2)]
    [TestCase(@"../../../Files/04Input.txt", 496)]
    public void Test_Day04_SolvePart01(
        string path,
        int result
    )
    {
        Assert.That(Day04.SolvePart01(path), Is.EqualTo(result));
    }
    
    [Test]
    [TestCase(@"../../../Files/04ExampleInput.txt", 4)]
    [TestCase(@"../../../Files/04Input.txt", 847)]
    public void Test_Day04_SolvePart02(
        string path,
        int result
    )
    {
        Assert.That(Day04.SolvePart02(path), Is.EqualTo(result));
    }
}