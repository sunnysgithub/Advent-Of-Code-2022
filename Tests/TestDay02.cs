using AdventOfCode;

namespace Tests;

public class TestDay02
{
    [Test]
    [TestCase(@"../../../Files/02ExampleInput.txt", 15, 12)]
    [TestCase(@"../../../Files/02Input.txt", 10941, 13071)]
    public void Test_Day02_CalculateTotalScore(
        string path,
        int resultPart01,
        int resultPart02
        )
    {
        Assert.That(Day02.CalculateTotalScore(path), Is.EqualTo((resultPart01, resultPart02)));
    }

}
