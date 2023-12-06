using LeetCode.Questions.Easy;
using NUnit.Framework;

namespace LeetCode.TestSuite.Easy
{
    [TestFixture]
    public class TestQ14
    {
        readonly Q14 q14;

        public TestQ14()
        {
            q14 = new Q14();
        }

        [Test]
        public void RomanToLongestCommonPrefixPass1()
        {
            string[] testInput = { "flower", "flow", "flight" };
            string expectedTestOutput = "fl";
            var actualOutput = q14.LongestCommonPrefix(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test]
        public void RomanToLongestCommonPrefixPass2()
        {
            string[] testInput = { "dog", "racecar", "car" };
            string expectedTestOutput = "";
            var actualOutput = q14.LongestCommonPrefix(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test] //new case added by me
        public void RomanToLongestCommonPrefixPass3()
        {
            string[] testInput = { "pale", "male", "scale", "tale" };
            string expectedTestOutput = "ale";
            var actualOutput = q14.LongestCommonPrefix(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }
    }
}
