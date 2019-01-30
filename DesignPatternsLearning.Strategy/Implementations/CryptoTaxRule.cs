using DesignPatternsLearning.Strategy.Contracts;
using DesignPatternsLearning.Strategy.Models;

namespace DesignPatternsLearning.Strategy.Implementations
{
    public class CryptoTaxRule : ITaxCalculationRule
    {
        public decimal ApplyRule(Investment investment)
        {
            return investment.YieldValue * .275m;
        }
    }
}
