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
    }
}
