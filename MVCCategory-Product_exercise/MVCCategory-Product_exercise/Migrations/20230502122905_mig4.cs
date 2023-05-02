using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCCategory_Product_exercise.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Instock", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, true, "iPhone 13", 9999m },
                    { 2, 1, true, "Samsung Galaxy S21", 7999m },
                    { 3, 1, true, "Xiaomi Mi 11 Lite", 3499m },
                    { 4, 2, true, "Macbook Pro", 16999m },
                    { 5, 2, true, "HP Pavilion", 7499m },
                    { 6, 2, true, "Asus ROG", 13999m },
                    { 7, 3, true, "Samsung 55'' 4K Smart TV", 6999m },
                    { 8, 3, true, "LG 65'' OLED TV", 13999m },
                    { 9, 3, true, "Sony 75'' 4K HDR TV", 21999m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);
        }
    }
}
