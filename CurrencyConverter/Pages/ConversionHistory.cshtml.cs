using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CurrencyConverter.Data;
using CurrencyConverter.Models;

namespace CurrencyConverter
{
    public class ConversionHistoryModel : PageModel
    {
        public IEnumerable<ConversionLog> Conversions { get; set; }

        [BindProperty]
        public DateTime? FromDate { get; set; }
        [BindProperty]
        public DateTime? ToDate { get; set; }
        
        //[BindProperty]
        //public string ErrorMessage { get; set; }

        private readonly IConversionRepository conversionRepository;

        public ConversionHistoryModel(IConversionRepository conversionRepository)
        {
            this.conversionRepository = conversionRepository;
        }
        public void OnGet()
        {
            Conversions = conversionRepository.GetAllConversions();
        }

        public void OnPost()
        {
            ViewData["ErrorMessage"] = string.Empty;
            Conversions = GetConversions();
        }

        public PartialViewResult OnGetAjaxConversionList(DateTime? searchFromDate, DateTime? searchToDate)
        {
            FromDate = searchFromDate;
            ToDate = searchToDate;
            Conversions = GetConversions();
            return Partial("_conversionList", Conversions);
        }

        private IEnumerable<ConversionLog> GetConversions()
        {
            if (FromDate.HasValue && ToDate.HasValue)
            {
                if (FromDate.Value.Date > ToDate.Value.Date)
                {
                    ViewData["ErrorMessage"] = "From Date can not be later than To Date";
                    Conversions = new List<ConversionLog>();
                }
                else
                {
                    Conversions = conversionRepository.GetAllConversions()
                        .Where(c => (c.ConversionDate.Date >= FromDate.Value.Date) &&
                        (c.ConversionDate.Date <= ToDate.Value.Date));
                }
            }
            else
            {
                Conversions = conversionRepository.GetAllConversions()
                .Where(c => (!FromDate.HasValue || c.ConversionDate.Date >= FromDate.Value.Date) &&
                (!ToDate.HasValue || c.ConversionDate.Date <= ToDate.Value.Date));
            }

            return Conversions;
        }
    }
}