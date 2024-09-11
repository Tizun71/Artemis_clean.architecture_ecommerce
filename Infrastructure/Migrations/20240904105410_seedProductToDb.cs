using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedProductToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CreatedDate", "ImageUrl", "IsAvailable", "Price", "ProductDescription", "ProductName", "StockQuantity", "UpdatedDate" },
                values: new object[] { 1, null, "", true, 3369000L, "Blazer Phantom tái hiện hình dáng cổ điển với kiểu dáng đẹp, thấp.", "Nike Blazer Phantom Low", 3, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);
        }
    }
}
