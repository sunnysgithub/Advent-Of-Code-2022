using AdventOfCode;

namespace Tests
{
    public class TestDay06
    {
        [Test]
        [TestCase(@"../../../Files/06ExampleInput01.txt", 5)]
        [TestCase(@"../../../Files/06ExampleInput02.txt", 6)]
        [TestCase(@"../../../Files/06ExampleInput03.txt", 10)]
        [TestCase(@"../../../Files/06ExampleInput04.txt", 11)]
        [TestCase(@"../../../Files/06Input.txt", 1210)]
        public void Test_Day06_Part01(
        string path,
        int result
        )
        {
            Assert.That(Day06.Part01(path), Is.EqualTo(result));
        }

        [Test]
        [TestCase(@"../../../Files/06ExampleInput05.txt", 19)]
        [TestCase(@"../../../Files/06ExampleInput06.txt", 23)]
        [TestCase(@"../../../Files/06ExampleInput07.txt", 23)]
        [TestCase(@"../../../Files/06ExampleInput08.txt", 29)]
        [TestCase(@"../../../Files/06ExampleInput09.txt", 26)]
        [TestCase(@"../../../Files/06Input.txt", 0)]
        public void Test_Day06_Part02(
        string path,
        int result
        )
        {
            Assert.That(Day06.Part02(path), Is.EqualTo(result));
        }
    }
}
