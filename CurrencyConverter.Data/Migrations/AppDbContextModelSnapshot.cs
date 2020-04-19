﻿// <auto-generated />
using System;
using CurrencyConverter.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurrencyConverter.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CurrencyConverter.Models.ConversionLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ConversionDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("FromAmount")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<int>("FromCurrency")
                        .HasColumnType("int");

                    b.Property<double>("RateApplied")
                        .HasColumnType("float");

                    b.Property<double>("ToAmount")
                        .HasColumnType("float");

                    b.Property<int>("ToCurrency")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Conversions");
                });

            modelBuilder.Entity("CurrencyConverter.Models.CurrencyConversionRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FromCurrency")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("ToCurrency")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rates");
                });
#pragma warning restore 612, 618
        }
    }
}
