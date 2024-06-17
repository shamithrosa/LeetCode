using LeetCode.Questions.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode.TestSuite.Easy
{
    [TestClass]
    public class TestQ28
    {
        string needle = string.Empty;
        string haystack = string.Empty;
        Q28 q28;

        public TestQ28()
        {
            q28 = new Q28();
        }

        [TestMethod]
        public void FindNeedleInHaystack_Pass1()
        {
            haystack = "leetcode";
            needle = "leet";
            int expectedValue = 0;
            var actualOutput = q28.FindNeedleInHaystack(haystack, needle);
            Assert.AreEqual(expectedValue, actualOutput);
        }

        [TestMethod]
        public void FindNeedleInHaystack_Pass2()
        {
            haystack = "happybuthappy";
            needle = "happy";
            int expectedValue = 0;
            var actualOutput = q28.FindNeedleInHaystack(haystack, needle);
            Assert.AreEqual(expectedValue, actualOutput);
        }

        [TestMethod]
        public void FindNeedleInHaystack_Pass3()
        {
            haystack = "leetcode";
            needle = "leeto";
            int expectedValue = -1;
            var actualOutput = q28.FindNeedleInHaystack(haystack, needle);
            Assert.AreEqual(expectedValue, actualOutput);
        }

        [TestMethod]
        public void FindNeedleInHaystack_Pass4()
        {
            haystack = "aaa";
            needle = "aaaa";
            int expectedValue = -1;
            var actualOutput = q28.FindNeedleInHaystack(haystack, needle);
            Assert.AreEqual(expectedValue, actualOutput);
        }

        [TestMethod]
        public void FindNeedleInHaystack_Pass5()
        {
            haystack = "a";
            needle = "a";
            int expectedValue = 0;
            var actualOutput = q28.FindNeedleInHaystack(haystack, needle);
            Assert.AreEqual(expectedValue, actualOutput);
        }

        [TestMethod]
        public void FindNeedleInHaystack_Pass6()
        {
            haystack = "mississippi";
            needle = "issipi";
            int expectedValue = -1;
            var actualOutput = q28.FindNeedleInHaystack(haystack, needle);
            Assert.AreEqual(expectedValue, actualOutput);
        }

        [TestMethod]
        public void FindNeedleInHaystack_Pass7()
        {
            haystack = "mississippi";
            needle = "sipp";
            int expectedValue = 6;
            var actualOutput = q28.FindNeedleInHaystack(haystack, needle);
            Assert.AreEqual(expectedValue, actualOutput);
        }

        [TestMethod]
        public void FindNeedleInHaystack_Pass8()
        {
            haystack = "sadbutsad";
            needle = "sad";
            int expectedValue = 0;
            var actualOutput = q28.FindNeedleInHaystack(haystack, needle);
            Assert.AreEqual(expectedValue, actualOutput);
        }
    }
}
