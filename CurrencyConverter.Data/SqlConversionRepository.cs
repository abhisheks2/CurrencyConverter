using CurrencyConverter.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CurrencyConverter.Data
{
    public class SqlConversionRepository : IConversionRepository
    {
        private readonly AppDbContext context;

        public SqlConversionRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddConversion(ConversionLog newConversion)
        {
            context.Conversions.Add(newConversion);
            context.SaveChanges();
        }

        public IEnumerable<ConversionLog> GetAllConversions()
        {
            return context.Conversions.OrderBy(c => c.ConversionDate);
        }

        public double GetConversionRate(Currency fromCurrency, Currency toCurrency)
        {
            return (context.Rates.SingleOrDefault(r => r.FromCurrency == fromCurrency && r.ToCurrency == toCurrency)).Rate;
        }
    }
}
