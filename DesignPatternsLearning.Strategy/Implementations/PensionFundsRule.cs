using DesignPatternsLearning.Strategy.Contracts;
using DesignPatternsLearning.Strategy.Models;
using System;

namespace DesignPatternsLearning.Strategy.Implementations
{
    public class PensionFundsRule : ITaxCalculationRule
    {
        public decimal ApplyRule(Investment investment)
        {
            if ((DateTime.Now.Subtract(investment.FirstApplicationDate).TotalDays / 365) > 10)
                return (investment.YieldValue * .10m);
            else
                return investment.YieldValue * .22m;
        }
    }
}
