using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxCalculatorVS2019.Models;

namespace TaxCalculator.Tests
{
    
    [TestClass]
    public class UnitTest1
    {
        private ITaxCalculator getTestObject()
        {
            return new CurrentTaxCalculator();
        }
        [TestMethod]
        public void TaxBracketOne()
        {
            //arrange
            ITaxCalculator target = getTestObject();
            decimal bracketOneSingle = 11300;

            //act
            var taxBracketOneSingle = target.FindTaxAmount(bracketOneSingle);

            //assert
            Assert.AreEqual(90M, taxBracketOneSingle);
        }
        [TestMethod]
        public void TaxBracketTwo()
        {
            //arrange
            ITaxCalculator target = getTestObject();
            decimal bracketTwoSingle = 30350;

            //act
            var taxBracketTwoSingle = target.FindTaxAmount(bracketTwoSingle);

            //assert
            Assert.AreEqual(2526.25M, taxBracketTwoSingle);
        }
    }
}
