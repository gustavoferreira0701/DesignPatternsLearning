using DesignPatternsLearning.Strategy.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesignPatternsLearning.Test.Strategy
{

    [TestClass]
    public class TaxCalculatorTestcs
    {
        private TaxCalculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new TaxCalculator();
        }

        [TestMethod]
        public void ShoudCalculateFixedIncome()
        {
            //given
            var investiment = new Investment("XYZ", EInvestmentType.FixedIncome, 1000, 1000, DateTime.Now);

            //when
            var tax = _calculator.CalculateTax(investiment);

            Assert.AreEqual(250m, tax);
        }

        [TestMethod]
        public void ShoudCalculatePensionWithMoreThanTenYears()
        {
            //given
            var investiment = new Investment("XYZ", EInvestmentType.PensionFunds, 1000, 1000, DateTime.Now.AddYears(-12));

            //when
            var tax = _calculator.CalculateTax(investiment);

            Assert.AreEqual(100m, tax);
        }
    }
}
