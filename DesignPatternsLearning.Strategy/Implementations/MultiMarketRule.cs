using DesignPatternsLearning.Strategy.Contracts;
using DesignPatternsLearning.Strategy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLearning.Strategy.Implementations
{
    public class MultiMarketRule : ITaxCalculationRule
    {
        public decimal ApplyRule(Investment investment)
        {
            return investment.YieldValue * .15m;
        }
    }
}
