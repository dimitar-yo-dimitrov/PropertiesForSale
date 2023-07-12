using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1", "Sofia" },
                    { "10", "Blagoevgrad" },
                    { "11", "Ruse" },
                    { "12", "Vratza" },
                    { "13", "Kuklen" },
                    { "14", "Asenovgrad" },
                    { "15", "Velingrad" },
                    { "16", "Koprivshtitza" },
                    { "17", "Gabrovo" },
                    { "18", "Sozopol" },
                    { "2", "Plovdiv" },
                    { "3", "Varna" },
                    { "4", "Burgas" },
                    { "5", "Stara Zagora" },
                    { "6", "Nesebar" },
                    { "7", "Bansko" },
                    { "8", "Veliko Tarnovo" },
                    { "9", "Smolyan" }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { "1", "House" },
                    { "2", "Apartment" },
                    { "3", "Villa" },
                    { "4", "Office" },
                    { "5", "Shop" },
                    { "6", "Hotel" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: "6");
        }
    }
}
