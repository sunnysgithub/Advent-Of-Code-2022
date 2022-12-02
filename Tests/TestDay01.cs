using AdventOfCode;

namespace Tests;

public class TestDay01
{
    [Test]
    [TestCase(@"Files/01ExampleInput.txt", 24000)]
    [TestCase(@"Files/01Input.txt", 69883)]
    public void Test_Day01_CalculateTheTotalOfTopElve(string path, int expected)
    {
        Assert.That(Day01.CalculateTheTotalOfTopElve(path), Is.EqualTo(expected));
    }

    [Test]
    [TestCase(@"Files/01ExampleInput.txt", 45000)]
    [TestCase(@"Files/01Input.txt", 69883)]
    public void Test_Day01_CalculateTheTotalOfTopElves(string path, int expected)
    {
        Assert.That(Day01.CalculateTheTotalOfTopElves(path, 3), Is.EqualTo(expected));
    }
}