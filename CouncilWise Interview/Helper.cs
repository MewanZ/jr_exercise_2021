using System;

namespace CouncilWise
{
    public static class Helper
    {
        public const decimal TaxRate = 0.1m;

        public static decimal CurrencyRound(this decimal value)
        {
            return Math.Round(value, 2);
        }
    }
}
