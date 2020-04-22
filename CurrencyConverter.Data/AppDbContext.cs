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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CurrencyConversionRate>().HasData(
                new CurrencyConversionRate { Id = 1, FromCurrency = Currency.GBP, ToCurrency = Currency.USD, Rate = 1.25 });
            modelBuilder.Entity<CurrencyConversionRate>().HasData(
                new CurrencyConversionRate { Id = 2, FromCurrency = Currency.GBP, ToCurrency = Currency.EUR, Rate = 1.15 });
            modelBuilder.Entity<CurrencyConversionRate>().HasData(
                new CurrencyConversionRate { Id = 3, FromCurrency = Currency.GBP, ToCurrency = Currency.AUD, Rate = 1.97 });
            modelBuilder.Entity<CurrencyConversionRate>().HasData(
                new CurrencyConversionRate { Id = 4, FromCurrency = Currency.EUR, ToCurrency = Currency.GBP, Rate = 0.87 });
            modelBuilder.Entity<CurrencyConversionRate>().HasData(
                new CurrencyConversionRate { Id = 5, FromCurrency = Currency.EUR, ToCurrency = Currency.USD, Rate = 1.09 });
            modelBuilder.Entity<CurrencyConversionRate>().HasData(
                new CurrencyConversionRate { Id = 6, FromCurrency = Currency.EUR, ToCurrency = Currency.AUD, Rate = 1.71 });
            modelBuilder.Entity<CurrencyConversionRate>().HasData(
                new CurrencyConversionRate { Id = 7, FromCurrency = Currency.USD, ToCurrency = Currency.GBP, Rate = 0.81 });
            modelBuilder.Entity<CurrencyConversionRate>().HasData(
                new CurrencyConversionRate { Id = 8, FromCurrency = Currency.USD, ToCurrency = Currency.EUR, Rate = 0.92 });
            modelBuilder.Entity<CurrencyConversionRate>().HasData(
                new CurrencyConversionRate { Id = 9, FromCurrency = Currency.USD, ToCurrency = Currency.AUD, Rate = 1.57 });
            modelBuilder.Entity<CurrencyConversionRate>().HasData(
                new CurrencyConversionRate { Id = 10, FromCurrency = Currency.AUD, ToCurrency = Currency.GBP, Rate = 0.51 });
            modelBuilder.Entity<CurrencyConversionRate>().HasData(
                new CurrencyConversionRate { Id = 11, FromCurrency = Currency.AUD, ToCurrency = Currency.EUR, Rate = 0.59 });
            modelBuilder.Entity<CurrencyConversionRate>().HasData(
                new CurrencyConversionRate { Id = 12, FromCurrency = Currency.AUD, ToCurrency = Currency.USD, Rate = 0.64 });
        }
    }
}
