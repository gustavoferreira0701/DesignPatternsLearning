using DesignPatternsLearning.Strategy.Contracts;
using DesignPatternsLearning.Strategy.Implementations;

namespace DesignPatternsLearning.Strategy.Models
{
    public class TaxCalculator
    {
        private ITaxCalculationRule _calculationRule;

        private void SetCalculationRule(Investment investment)
        {
            switch (investment.InvestmentType)
            {
                case EInvestmentType.FixedIncome:
                    _calculationRule = new FixedIncomeRule();
                    break;
                case EInvestmentType.MultiMarket:
                    _calculationRule = new MultiMarketRule();
                    break;
                case EInvestmentType.PensionFunds:
                    _calculationRule = new PensionFundsRule();
                    break;
                case EInvestmentType.Stock:
                    _calculationRule = new StockRule();
                    break;
                case EInvestmentType.Crypto:
                    _calculationRule = new CryptoTaxRule();
                    break;
                default:
                    _calculationRule = new NotDefinedTaxRule();
                    break;
            }
        }

        public decimal CalculateTax(Investment investment)
        {
            SetCalculationRule(investment);

            return _calculationRule.ApplyRule(investment);
        }
    }
}
