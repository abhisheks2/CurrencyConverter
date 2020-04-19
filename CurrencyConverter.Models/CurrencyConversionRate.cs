using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyConverter.Models
{
    public class CurrencyConversionRate
    {
        public int Id { get; set; }
        public Currency FromCurrency { get; set; }
        public Currency ToCurrency { get; set; }
        public double Rate { get; set; }
    }
}
