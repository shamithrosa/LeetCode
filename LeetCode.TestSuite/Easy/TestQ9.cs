using LeetCode.Questions.Easy;
using NUnit.Framework;

namespace LeetCode.TestSuite.Easy
{
    [TestFixture]
    public class TestQ9
    {
        Q9 q9;

        public TestQ9()
        {
            q9 = new Q9();
        }

        [Test]
        public void IsPalindromePass1()
        {
            int testInput = 121;
            bool expectedTestOutput = true;
            var actualOutput = q9.IsPalindrome(testInput); 
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test]
        public void IsPalindromePass2()
        {
            int testInput = -121;
            bool expectedTestOutput = false;
            var actualOutput = q9.IsPalindrome(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test]
        public void IsPalindromePass3()
        {
            int testInput = 10;
            bool expectedTestOutput = false;
            var actualOutput = q9.IsPalindrome(testInput);
            Assert.AreEqual(expectedTestOutput, actualOutput);
        }
    }
}
