using DesignPatternsLearning.Strategy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLearning.Strategy.Contracts
{
    public interface ITaxCalculationRule
    {
        decimal ApplyRule(Investment investment);
    }
}
