using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopFa.Migrations
{
    public partial class updateBestPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "BestPrices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BestPrices_CategoryId",
                table: "BestPrices",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BestPrices_Categories_CategoryId",
                table: "BestPrices",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BestPrices_Categories_CategoryId",
                table: "BestPrices");

            migrationBuilder.DropIndex(
                name: "IX_BestPrices_CategoryId",
                table: "BestPrices");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "BestPrices");
        }
    }
}
