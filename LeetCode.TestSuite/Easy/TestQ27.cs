using LeetCode.Questions.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode.TestSuite.Easy
{
    [TestClass]
    public class TestQ27
    {
        readonly Q27 q27;

        public TestQ27()
        {
            q27 = new Q27();
        }

        [TestMethod]
        public void RemoveElementPass1()
        {
            int[] testInputNums = { 3, 2, 2, 3 };
            int elementToRemove = 3;
            int expectedTestOutput = 2;
            var actualOutput = q27.RemoveElement(testInputNums, elementToRemove);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [TestMethod]
        public void RemoveElementPass2()
        {
            int[] testInputNums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int elementToRemove = 2;
            int expectedTestOutput = 5;
            var actualOutput = q27.RemoveElement(testInputNums, elementToRemove);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }
    }
}
