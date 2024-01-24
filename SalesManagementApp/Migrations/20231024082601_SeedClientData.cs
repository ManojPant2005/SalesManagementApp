using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedClientData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phonenumber",
                table: "Clients",
                newName: "PhoneNumber");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "FirstName", "JobTitle", "LastName", "PhoneNumber", "RetailOutletId" },
                values: new object[,]
                {
                    { 1, "james.tailor@company.com", "James", "Buyer", "Tailor", "000000000", 1 },
                    { 2, "jill.hutton@company.com", "Jill", "Buyer", "Hutton", "000000000", 2 },
                    { 3, "craig.rice@company.com", "Craig", "Buyer", "Rice", "000000000", 3 },
                    { 4, "amy.smith@company.com", "Amy", "Buyer", "Smith", "000000000", 4 }
                });

            migrationBuilder.InsertData(
                table: "RetailOutlets",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "TX", "Texas Outdoor Store" },
                    { 2, "CA", "California Outdoor Store" },
                    { 3, "NY", "New York Outdoor Store" },
                    { 4, "WA", " Washington Outdoor Store" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RetailOutlets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RetailOutlets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RetailOutlets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RetailOutlets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Clients",
                newName: "Phonenumber");
        }
    }
}
