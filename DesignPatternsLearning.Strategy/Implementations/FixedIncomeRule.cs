using DesignPatternsLearning.Strategy.Contracts;
using DesignPatternsLearning.Strategy.Models;

namespace DesignPatternsLearning.Strategy.Implementations
{
    public class FixedIncomeRule : ITaxCalculationRule
    {
        public decimal ApplyRule(Investment investment)
        {
            return investment.YieldValue * .25m;
        }
    }
}
