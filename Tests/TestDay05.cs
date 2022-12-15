using AdventOfCode;

namespace Tests
{
    public class TestDay05
    {
        [Test]
        [TestCase(@"../../../Files/05ExampleInput.txt", "CMZ")]
        [TestCase(@"../../../Files/05Input.txt", "JRVNHHCSJ")]
        public void Test_Day05_Part01(
        string path,
        string result
        )
        {
            Assert.That(Day05.Part01(path), Is.EqualTo(result));
        }

        [Test]
        [TestCase(@"../../../Files/05ExampleInput.txt", "MCD")]
        [TestCase(@"../../../Files/05Input.txt", "ABC")]
        public void Test_Day05_Part02(
        string path,
        string result
        )
        {
            Assert.That(Day05.Part02(path), Is.EqualTo(result));
        }
    }
}
