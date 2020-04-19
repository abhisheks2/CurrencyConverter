using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CurrencyConverter.Models
{
    public class ConversionLog
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "From Currency is required")]
        [Display(Name = "From Currency")]
        public Currency? FromCurrency { get; set; }

        [Required(ErrorMessage = "To Currency is required")]
        [Display(Name = "To Currency")]
        public Currency? ToCurrency { get; set; }
        
        [Required]
        [Display(Name = "From Amount")]
        public double? FromAmount { get; set; }
        
        [Display(Name = "To Amount")]
        public double ToAmount { get; set; }
        
        public double RateApplied { get; set; }
        public DateTime ConversionDate { get; set; }
    }
}
