using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopFa.Migrations
{
    public partial class fixshowlist2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BestPrices",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    CheapestPrice = table.Column<float>(type: "real", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BestPrices", x => new { x.ProductId, x.SellerId });
                    table.ForeignKey(
                        name: "FK_BestPrices_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BestPrices_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BestPrices_ProductId",
                table: "BestPrices",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BestPrices_SellerId",
                table: "BestPrices",
                column: "SellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BestPrices");
        }
    }
}
