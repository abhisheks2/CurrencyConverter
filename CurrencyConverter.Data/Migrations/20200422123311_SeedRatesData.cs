using Microsoft.EntityFrameworkCore.Migrations;

namespace CurrencyConverter.Data.Migrations
{
    public partial class SeedRatesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rates",
                columns: new[] { "Id", "FromCurrency", "Rate", "ToCurrency" },
                values: new object[,]
                {
                    { 1, 0, 1.25, 2 },
                    { 2, 0, 1.1499999999999999, 1 },
                    { 3, 0, 1.97, 3 },
                    { 4, 1, 0.87, 0 },
                    { 5, 1, 1.0900000000000001, 2 },
                    { 6, 1, 1.71, 3 },
                    { 7, 2, 0.81000000000000005, 0 },
                    { 8, 2, 0.92000000000000004, 1 },
                    { 9, 2, 1.5700000000000001, 3 },
                    { 10, 3, 0.51000000000000001, 0 },
                    { 11, 3, 0.58999999999999997, 1 },
                    { 12, 3, 0.64000000000000001, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
