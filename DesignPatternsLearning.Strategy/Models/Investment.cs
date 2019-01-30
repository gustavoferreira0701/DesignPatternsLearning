using System;

namespace DesignPatternsLearning.Strategy.Models
{
    public class Investment
    {
        public string FundName { get; private set; }
        public EInvestmentType InvestmentType { get; private set; }
        public decimal ApplicationValue { get; private set; }
        public decimal YieldValue { get; private set; }
        public DateTime FirstApplicationDate { get; private set; }
        public decimal PositionValue
        {
            get
            {
                return ApplicationValue + PositionValue;
            }
        }

        public Investment(string fundName, EInvestmentType investmentType, decimal applicationValue, decimal yieldValue, DateTime applicationDate)
        {
            FundName = fundName;
            InvestmentType = investmentType;
            ApplicationValue = applicationValue;
            YieldValue = yieldValue;
            FirstApplicationDate = applicationDate;
        }
    }
}
