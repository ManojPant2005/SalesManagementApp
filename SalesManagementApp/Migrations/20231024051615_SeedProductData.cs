using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mountain Bikes" },
                    { 2, "Road Bikes" },
                    { 3, "Camping" },
                    { 4, "Hiking" },
                    { 5, "Boots" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/MountainBike1.jpg", "Mountain Bike 1", 200m },
                    { 2, 1, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/MountainBike2.jpg", "Mountain Bike 2", 210m },
                    { 3, 2, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/RoadBike1.jpg", "Road Bike 1", 240m },
                    { 4, 2, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/RoadBike2.jpg", "Road Bike 2", 250m },
                    { 5, 2, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/RoadBike3.jpg", "Road Bike 3", 252m },
                    { 6, 2, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/RoadBike4.jpg", "Road Bike 4", 230m },
                    { 7, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/Tent1.jpg", "Tent 1", 230m },
                    { 8, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/Tent2.jpg", "Tent 2", 230m },
                    { 9, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/Mattress1.jpg", "Air Mattress 1", 11m },
                    { 10, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/Mattress2.jpg", "Air Mattress 2", 40m },
                    { 11, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/Mattress3.jpg", "Air Mattress 3", 54m },
                    { 12, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/Mattress4.jpg", "Air Mattress 4", 15m },
                    { 13, 4, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/Pack1.jpg", "Pack 1", 24m },
                    { 14, 4, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/Pack2.jpg", "Pack 2", 30m },
                    { 15, 4, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/Pack3.jpg", "Pack 3", 35m },
                    { 16, 5, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/Boot1.jpg", "Boot 1", 20m },
                    { 17, 5, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/Boot2.jpg", "Boot 2", 38m },
                    { 18, 5, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/Boot3.jpg", "Boot 3", 35m },
                    { 19, 5, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/Boot4.jpg", "Boot 4", 31m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);
        }
    }
}
