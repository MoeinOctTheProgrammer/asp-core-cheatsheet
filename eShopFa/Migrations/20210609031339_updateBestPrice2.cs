using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopFa.Migrations
{
    public partial class updateBestPrice2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BestPrices",
                table: "BestPrices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BestPrices",
                table: "BestPrices",
                columns: new[] { "ProductId", "SellerId", "CategoryId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BestPrices",
                table: "BestPrices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BestPrices",
                table: "BestPrices",
                columns: new[] { "ProductId", "SellerId" });
        }
    }
}
