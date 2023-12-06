using LeetCode.Questions.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.TestSuite.Easy
{
    [TestClass]
    public class TestQ20
    {
        readonly Q20 q20;

        public TestQ20()
        {
            q20 = new Q20();
        }

        [TestMethod]
        public void IsValidParenthesesPass1()
        {
            string testInput = "()";
            bool expectedTestOutput = true;
            var actualOutput = q20.IsValidParentheses(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }
        
        [TestMethod]
        public void IsValidParenthesesPass2()
        {
            string testInput = "()[]{}";
            bool expectedTestOutput = true;
            var actualOutput = q20.IsValidParentheses(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }


        [TestMethod]
        public void IsValidParenthesesPass3()
        {
            string testInput = "(}";
            bool expectedTestOutput = false;
            var actualOutput = q20.IsValidParentheses(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [TestMethod]
        public void IsValidParanthesesPass4()
        {
            string testInput = "([)]";
            bool expectedTestOutput = false;
            var actualOutput = q20.IsValidParentheses(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [TestMethod]
        public void IsValidParanthesesPass5()
        {
            string testInput = "(){}}{";
            bool expectedTestOutput = false;
            var actualOutput = q20.IsValidParentheses(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [TestMethod]
        public void IsValidParanthesesPass6()
        {
            string testInput = "({{{{}}}))";
            bool expectedTestOutput = false;
            var actualOutput = q20.IsValidParentheses(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [TestMethod]
        public void IsValidParanthesesPass7()
        {
            string testInput = "([{}])";
            bool expectedTestOutput = true;
            var actualOutput = q20.IsValidParentheses(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }
    }
}
