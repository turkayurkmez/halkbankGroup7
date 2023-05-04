using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eshop.Data.Migrations
{
    /// <inheritdoc />
    public partial class create_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bilgisayar" },
                    { 2, "Giyim" },
                    { 3, "Mobilya" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "DiscountRate", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Lenovo Laptop", 0.14999999999999999, "https://cdn.dsmcdn.com/ty515/product/media/images/20220820/15/163144774/548362614/1/1_org.jpg", "Lenovo X65", 150000m },
                    { 2, 2, "Tek renk tişörtler", 0.25, "https://cdn.dsmcdn.com/ty515/product/media/images/20220820/15/163144774/548362614/1/1_org.jpg", "Basic Tişört", 250m },
                    { 3, 3, "Orta Sehpa", 0.10000000000000001, "https://cdn.dsmcdn.com/ty515/product/media/images/20220820/15/163144774/548362614/1/1_org.jpg", "Vivense orta sehpa", 300m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
