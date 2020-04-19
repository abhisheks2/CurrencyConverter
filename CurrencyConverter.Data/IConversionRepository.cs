using System;
using System.Collections.Generic;
using CurrencyConverter.Models;

namespace CurrencyConverter.Data
{
    public interface IConversionRepository
    {
        IEnumerable<ConversionLog> GetAllConversions();
        void AddConversion(ConversionLog newConversion);
        double GetConversionRate(Currency fromCurrency, Currency toCurrency);
    }
}
