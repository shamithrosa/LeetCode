using LeetCode.Questions.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.TestSuite.Easy
{
    [TestClass]
    public class TestQ26
    {
        readonly Q26 q26;

        public TestQ26()
        {
            q26 = new Q26();
        }

        [TestMethod]
        public void RemoveDuplicatesPass1()
        {
            int[] testInput = { 1, 1, 2, 3, 4, 4 };

            int[] expectedTestOutput = { 1, 2, 3, 4 };
            int expectedKValue = 4;

            var actualOutput = q26.RemoveDuplicates(testInput);
            Assert.AreEqual(expectedKValue, actualOutput);
        }

        [TestMethod]
        public void RemoveDuplicatesPass2()
        {
            int[] testInput = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            int[] expectedTestOutput = { 0, 1, 2, 3, 4 };
            int expectedKValue = 5;

            var actualOutput = q26.RemoveDuplicates(testInput);
            Assert.AreEqual(expectedKValue, actualOutput);
        }
    }
}
