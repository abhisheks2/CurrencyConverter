using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CurrencyConverter.Data;
using CurrencyConverter.Models;

namespace CurrencyConverter.Pages
{
    public class ConverterModel : PageModel
    {
        [BindProperty]
        public ConversionLog CurrencyConversion { get; set; }

        private readonly IConversionRepository conversionRepository;

        public ConverterModel(IConversionRepository conversionRepository)
        {
            this.conversionRepository = conversionRepository;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                CurrencyConversion.RateApplied = conversionRepository.GetConversionRate(CurrencyConversion.FromCurrency.Value, CurrencyConversion.ToCurrency.Value);
                CurrencyConversion.ToAmount = Math.Round((CurrencyConversion.FromAmount.Value * CurrencyConversion.RateApplied), 2);
                CurrencyConversion.ConversionDate = DateTime.Now;
                conversionRepository.AddConversion(CurrencyConversion);
            }
        }
    }
}
