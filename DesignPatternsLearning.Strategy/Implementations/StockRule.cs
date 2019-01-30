using DesignPatternsLearning.Strategy.Contracts;
using DesignPatternsLearning.Strategy.Models;

namespace DesignPatternsLearning.Strategy.Implementations
{
    public class StockRule : ITaxCalculationRule
    {
        public decimal ApplyRule(Investment investment)
        {
            return investment.YieldValue * .15m;
        }
    }
}
