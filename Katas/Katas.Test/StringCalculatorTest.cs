using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Katas;

namespace Katas.Test
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void Should_ReturnZero_When_EmptyString()
        {
            var stringCalculator = new StringCalculator();
            var res = stringCalculator.Add("");
            Assert.AreEqual(0,res);
        }

        [TestMethod]
        public void Should_ReturnTheNumber_When_SingleNumber()
        {
            var stringCalculator = new StringCalculator();
            var res = stringCalculator.Add("1");
            Assert.AreEqual(1, res);

            res = stringCalculator.Add("3");
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void Should_ReturnSum_When_TwoNumbers()
        {
            var stringCalculator = new StringCalculator();
            var res = stringCalculator.Add("1,2");
            Assert.AreEqual(3, res);

            res = stringCalculator.Add("3,5");
            Assert.AreEqual(8, res);
        }

        [TestMethod]
        public void Should_ReturnSum_When_MultipleNumbers()
        {
            var stringCalculator = new StringCalculator();
            var res = stringCalculator.Add("1,2,3");
            Assert.AreEqual(6, res);

            res = stringCalculator.Add("3,5,3,9");
            Assert.AreEqual(20, res);
        }

        [TestMethod]
        public void Should_ReturnSum_When_LineBreaks()
        {
            var stringCalculator = new StringCalculator();
            var res = stringCalculator.Add("1,2\n3");
            Assert.AreEqual(6, res);

            res = stringCalculator.Add("3\n5\n3,9");
            Assert.AreEqual(20, res);
        }
    }
}
