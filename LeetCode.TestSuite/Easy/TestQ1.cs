using LeetCode.Questions.Easy;
using NUnit.Framework;

namespace LeetCode.TestSuite.Easy
{
    [TestFixture]
    public class TestQ1
    {
        Q1 q1;
        readonly int targetValue = 9;

        public TestQ1()
        {
            q1 = new Q1();
        }

        [Test]
        public void TwoSumPass1()
        {
            int[] testInput = { 2, 7, 1, 6 };
            int[] expectedTestOutput = { 0, 1 };
            var actualOutput = q1.TwoSum(testInput, targetValue);
            Assert.IsNotNull(actualOutput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test]
        public void TwoSumPass2()
        {
            int[] testInput = { 2, 7 };
            int[] expectedTestOutput = { 0, 1 };
            var actualOutput = q1.TwoSum(testInput, targetValue);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test]
        public void TwoSumPass3()
        {
            int[] testInput = { 2, 4, 7 };
            int[] expectedTestOutput = { 0, 2 };
            var actualOutput = q1.TwoSum(testInput, targetValue);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }
    }
}
