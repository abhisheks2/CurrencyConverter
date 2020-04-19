using System;
using System.Collections.Generic;
using System.Text;
using CurrencyConverter.Models;
using System.Linq;

namespace CurrencyConverter.Data
{
    public class InMemoryConversionRepository : IConversionRepository
    {
        private Dictionary<string, double> dictConversionRate = new Dictionary<string, double>()
        {
            { "GBPtoUSD", 1.25}, { "GBPtoEUR", 1.15}, { "GBPtoAUD", 1.97},
            { "EURtoGBP", 0.87}, { "EURtoUSD", 1.09}, { "EURtoAUD", 1.71},
            { "USDtoGBP", 0.81}, { "USDtoEUR", 0.92}, { "USDtoAUD", 1.57},
            { "AUDtoGBP", 0.51}, { "AUDtoEUR", 0.59}, { "AUDtoUSD", 0.64}
        };

        private List<ConversionLog> _conversionList;

        public InMemoryConversionRepository()
        {
            _conversionList = new List<ConversionLog>() 
            {
                new ConversionLog() { Id=1,FromCurrency=Currency.GBP,FromAmount=100,
                    ToCurrency=Currency.EUR,ToAmount=135,RateApplied=1.35,
                    ConversionDate = DateTime.Now},
                new ConversionLog() { Id=1,FromCurrency=Currency.GBP,FromAmount=100,
                    ToCurrency=Currency.EUR,ToAmount=135,RateApplied=1.35,
                    ConversionDate = DateTime.Now.AddDays(1)},
                new ConversionLog() { Id=1,FromCurrency=Currency.GBP,FromAmount=100,
                    ToCurrency=Currency.EUR,ToAmount=135,RateApplied=1.35,
                    ConversionDate = DateTime.Now.AddDays(2)},
                new ConversionLog() { Id=1,FromCurrency=Currency.GBP,FromAmount=100,
                    ToCurrency=Currency.EUR,ToAmount=135,RateApplied=1.35,
                    ConversionDate = DateTime.Now.AddDays(3)}
            };
        }

        public void AddConversion(ConversionLog newConversion)
        {
            if (_conversionList.Count == 0)
            {
                newConversion.Id = 1;
                _conversionList.Add(newConversion);
            }
            else
            {
                newConversion.Id = _conversionList.Max(c => c.Id) + 1;
                _conversionList.Add(newConversion);
            }
        }

        public IEnumerable<ConversionLog> GetAllConversions()
        {
            return _conversionList.OrderBy(c => c.ConversionDate);
        }

        public double GetConversionRate(Currency fromCurrency, Currency toCurrency)
        {
            string dictKey = fromCurrency + "to" + toCurrency;
            return dictConversionRate[dictKey];
        }
    }
}
