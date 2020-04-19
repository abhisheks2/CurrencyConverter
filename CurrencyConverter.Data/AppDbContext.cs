using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using CurrencyConverter.Models;

namespace CurrencyConverter.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ConversionLog> Conversions { get; set; }
        public DbSet<CurrencyConversionRate> Rates { get; set; }
    }
}
