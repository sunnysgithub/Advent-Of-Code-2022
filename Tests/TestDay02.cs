using AdventOfCode;

namespace Tests;

public class TestDay02
{
    [Test]
    [TestCase(@"Files/02ExampleInput.txt", 15)]
    [TestCase(@"Files/02Input.txt", 10941)]
    public void Test_Day02_CalculateTotalScore(string path, int expected)
    {
        Assert.That(Day02.CalculateTotalScore(path), Is.EqualTo(expected));
    }

}
