using LeetCode.Questions.Easy;
using NUnit.Framework;

namespace LeetCode.TestSuite.Easy
{
    [TestFixture]
    public class TestQ13
    {
        Q13 q13;

        public TestQ13()
        {
            q13 = new Q13();
        }

        [Test]
        public void RomanToIntPass1()
        {
            string testInput = "III";
            int expectedTestOutput = 3;
            var actualOutput = q13.RomanToInt(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test]
        public void RomanToIntPass2()
        {
            string testInput = "LVIII";
            int expectedTestOutput = 58;
            var actualOutput = q13.RomanToInt(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test]
        public void RomanToIntPass3()
        {
            string testInput = "MCMXCIV";
            int expectedTestOutput = 1994;
            var actualOutput = q13.RomanToInt(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test]
        public void RomanToIntPass4()
        {
            string testInput = "IX";
            int expectedTestOutput = 9;
            var actualOutput = q13.RomanToInt(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test]
        public void RomanToIntPass5()
        {
            string testInput = "XIV";
            int expectedTestOutput = 14;
            var actualOutput = q13.RomanToInt(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test]
        public void RomanToIntPass6()
        {
            string testInput = "MDLXX";
            int expectedTestOutput = 1570;
            var actualOutput = q13.RomanToInt(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }
    }
}
