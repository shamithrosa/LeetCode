using LeetCode.Questions.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace LeetCode.TestSuite.Medium
{
    [TestFixture]
    public class TestQ29
    {
        Q29 q29;
        
        public TestQ29()
        {
            q29 = new Q29();
        }

        [Test]
        public void Divide_Pass1()
        {
            int dividend = 10;
            int divisor = 3;
            int expectedTestOutput = 3;
            var actualOutput = q29.Divide(dividend, divisor);
            NUnit.Framework.Assert.IsNotNull(actualOutput);
            NUnit.Framework.Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test]
        public void Divide_Pass2()
        {
            int dividend = 7;
            int divisor = -3;
            int expectedTestOutput = -2;
            var actualOutput = q29.Divide(dividend, divisor);
            NUnit.Framework.Assert.IsNotNull(actualOutput);
            NUnit.Framework.Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test]
        public void Divide_Pass3()
        {
            int dividend = 2147483647;
            int divisor = 1;
            int expectedTestOutput = 2147483647;
            var actualOutput = q29.Divide(dividend, divisor);
            NUnit.Framework.Assert.IsNotNull(actualOutput);
            NUnit.Framework.Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test]
        public void Divide_Pass4()
        {
            int dividend = 100;
            int divisor = 3;
            int expectedTestOutput = 33;
            var actualOutput = q29.Divide(dividend, divisor);
            NUnit.Framework.Assert.IsNotNull(actualOutput);
            NUnit.Framework.Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test]
        public void Divide_Pass5()
        {
            int dividend = -10;
            int divisor = 3;
            int expectedTestOutput = -3;
            var actualOutput = q29.Divide(dividend, divisor);
            NUnit.Framework.Assert.IsNotNull(actualOutput);
            NUnit.Framework.Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test]
        public void Divide_Pass6()
        {
            int dividend = -10;
            int divisor = -3;
            int expectedTestOutput = 3;
            var actualOutput = q29.Divide(dividend, divisor);
            NUnit.Framework.Assert.IsNotNull(actualOutput);
            NUnit.Framework.Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        [Test]
        public void Divide_Pass7()
        {
            int dividend = 7;
            int divisor = 8;
            int expectedTestOutput = 0;
            var actualOutput = q29.Divide(dividend, divisor);
            NUnit.Framework.Assert.IsNotNull(actualOutput);
            NUnit.Framework.Assert.AreEqual(expectedTestOutput, actualOutput);
        }

        //edge case
        [Test]
        public void Divide_Pass8_EdgeCase()
        {
            int dividend = Int32.MinValue;
            int divisor = -1;
            int expectedTestOutput = Int32.MaxValue;
            var actualOutput = q29.Divide(dividend, divisor);
            NUnit.Framework.Assert.IsNotNull(actualOutput);
            NUnit.Framework.Assert.AreEqual(expectedTestOutput, actualOutput);
        }
    }
}
