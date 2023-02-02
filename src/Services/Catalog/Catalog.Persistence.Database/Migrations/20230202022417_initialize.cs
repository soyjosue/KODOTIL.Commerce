using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 150, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 787m },
                    { 72, "Description for product 72", "Product 72", 374m },
                    { 71, "Description for product 71", "Product 71", 712m },
                    { 70, "Description for product 70", "Product 70", 666m },
                    { 69, "Description for product 69", "Product 69", 893m },
                    { 68, "Description for product 68", "Product 68", 695m },
                    { 67, "Description for product 67", "Product 67", 462m },
                    { 66, "Description for product 66", "Product 66", 231m },
                    { 65, "Description for product 65", "Product 65", 927m },
                    { 64, "Description for product 64", "Product 64", 571m },
                    { 63, "Description for product 63", "Product 63", 107m },
                    { 62, "Description for product 62", "Product 62", 981m },
                    { 61, "Description for product 61", "Product 61", 197m },
                    { 60, "Description for product 60", "Product 60", 977m },
                    { 59, "Description for product 59", "Product 59", 423m },
                    { 58, "Description for product 58", "Product 58", 423m },
                    { 57, "Description for product 57", "Product 57", 752m },
                    { 56, "Description for product 56", "Product 56", 194m },
                    { 55, "Description for product 55", "Product 55", 466m },
                    { 54, "Description for product 54", "Product 54", 173m },
                    { 53, "Description for product 53", "Product 53", 166m },
                    { 52, "Description for product 52", "Product 52", 384m },
                    { 73, "Description for product 73", "Product 73", 758m },
                    { 51, "Description for product 51", "Product 51", 751m },
                    { 74, "Description for product 74", "Product 74", 190m },
                    { 76, "Description for product 76", "Product 76", 433m },
                    { 97, "Description for product 97", "Product 97", 314m },
                    { 96, "Description for product 96", "Product 96", 780m },
                    { 95, "Description for product 95", "Product 95", 219m },
                    { 94, "Description for product 94", "Product 94", 290m },
                    { 93, "Description for product 93", "Product 93", 989m },
                    { 92, "Description for product 92", "Product 92", 126m },
                    { 91, "Description for product 91", "Product 91", 214m },
                    { 90, "Description for product 90", "Product 90", 831m },
                    { 89, "Description for product 89", "Product 89", 139m },
                    { 88, "Description for product 88", "Product 88", 414m },
                    { 87, "Description for product 87", "Product 87", 461m },
                    { 86, "Description for product 86", "Product 86", 330m },
                    { 85, "Description for product 85", "Product 85", 642m },
                    { 84, "Description for product 84", "Product 84", 325m },
                    { 83, "Description for product 83", "Product 83", 302m },
                    { 82, "Description for product 82", "Product 82", 435m },
                    { 81, "Description for product 81", "Product 81", 209m },
                    { 80, "Description for product 80", "Product 80", 798m },
                    { 79, "Description for product 79", "Product 79", 726m },
                    { 78, "Description for product 78", "Product 78", 600m },
                    { 77, "Description for product 77", "Product 77", 983m },
                    { 75, "Description for product 75", "Product 75", 429m },
                    { 98, "Description for product 98", "Product 98", 236m },
                    { 50, "Description for product 50", "Product 50", 635m },
                    { 48, "Description for product 48", "Product 48", 872m },
                    { 22, "Description for product 22", "Product 22", 692m },
                    { 21, "Description for product 21", "Product 21", 655m },
                    { 20, "Description for product 20", "Product 20", 191m },
                    { 19, "Description for product 19", "Product 19", 407m },
                    { 18, "Description for product 18", "Product 18", 926m },
                    { 17, "Description for product 17", "Product 17", 688m },
                    { 16, "Description for product 16", "Product 16", 162m },
                    { 15, "Description for product 15", "Product 15", 533m },
                    { 14, "Description for product 14", "Product 14", 820m },
                    { 13, "Description for product 13", "Product 13", 201m },
                    { 12, "Description for product 12", "Product 12", 850m },
                    { 11, "Description for product 11", "Product 11", 658m },
                    { 10, "Description for product 10", "Product 10", 542m },
                    { 9, "Description for product 9", "Product 9", 866m },
                    { 8, "Description for product 8", "Product 8", 869m },
                    { 7, "Description for product 7", "Product 7", 261m },
                    { 6, "Description for product 6", "Product 6", 405m },
                    { 5, "Description for product 5", "Product 5", 713m },
                    { 4, "Description for product 4", "Product 4", 100m },
                    { 3, "Description for product 3", "Product 3", 132m },
                    { 2, "Description for product 2", "Product 2", 865m },
                    { 23, "Description for product 23", "Product 23", 213m },
                    { 49, "Description for product 49", "Product 49", 977m },
                    { 24, "Description for product 24", "Product 24", 708m },
                    { 26, "Description for product 26", "Product 26", 735m },
                    { 47, "Description for product 47", "Product 47", 625m },
                    { 46, "Description for product 46", "Product 46", 878m },
                    { 45, "Description for product 45", "Product 45", 981m },
                    { 44, "Description for product 44", "Product 44", 613m },
                    { 43, "Description for product 43", "Product 43", 708m },
                    { 42, "Description for product 42", "Product 42", 322m },
                    { 41, "Description for product 41", "Product 41", 761m },
                    { 40, "Description for product 40", "Product 40", 316m },
                    { 39, "Description for product 39", "Product 39", 268m },
                    { 38, "Description for product 38", "Product 38", 413m },
                    { 37, "Description for product 37", "Product 37", 449m },
                    { 36, "Description for product 36", "Product 36", 867m },
                    { 35, "Description for product 35", "Product 35", 926m },
                    { 34, "Description for product 34", "Product 34", 505m },
                    { 33, "Description for product 33", "Product 33", 488m },
                    { 32, "Description for product 32", "Product 32", 527m },
                    { 31, "Description for product 31", "Product 31", 614m },
                    { 30, "Description for product 30", "Product 30", 394m },
                    { 29, "Description for product 29", "Product 29", 861m },
                    { 28, "Description for product 28", "Product 28", 280m },
                    { 27, "Description for product 27", "Product 27", 308m },
                    { 25, "Description for product 25", "Product 25", 677m },
                    { 99, "Description for product 99", "Product 99", 685m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 19 },
                    { 72, 72, 15 },
                    { 71, 71, 5 },
                    { 70, 70, 4 },
                    { 69, 69, 19 },
                    { 68, 68, 4 },
                    { 67, 67, 14 },
                    { 66, 66, 0 },
                    { 65, 65, 12 },
                    { 64, 64, 7 },
                    { 63, 63, 10 },
                    { 62, 62, 8 },
                    { 61, 61, 8 },
                    { 60, 60, 12 },
                    { 59, 59, 4 },
                    { 58, 58, 12 },
                    { 57, 57, 5 },
                    { 56, 56, 0 },
                    { 55, 55, 6 },
                    { 54, 54, 17 },
                    { 53, 53, 4 },
                    { 52, 52, 8 },
                    { 73, 73, 8 },
                    { 51, 51, 16 },
                    { 74, 74, 11 },
                    { 76, 76, 10 },
                    { 97, 97, 15 },
                    { 96, 96, 0 },
                    { 95, 95, 5 },
                    { 94, 94, 0 },
                    { 93, 93, 14 },
                    { 92, 92, 17 },
                    { 91, 91, 18 },
                    { 90, 90, 19 },
                    { 89, 89, 18 },
                    { 88, 88, 17 },
                    { 87, 87, 18 },
                    { 86, 86, 10 },
                    { 85, 85, 9 },
                    { 84, 84, 6 },
                    { 83, 83, 4 },
                    { 82, 82, 4 },
                    { 81, 81, 4 },
                    { 80, 80, 13 },
                    { 79, 79, 0 },
                    { 78, 78, 6 },
                    { 77, 77, 7 },
                    { 75, 75, 6 },
                    { 98, 98, 5 },
                    { 50, 50, 13 },
                    { 48, 48, 8 },
                    { 22, 22, 19 },
                    { 21, 21, 17 },
                    { 20, 20, 15 },
                    { 19, 19, 4 },
                    { 18, 18, 1 },
                    { 17, 17, 14 },
                    { 16, 16, 15 },
                    { 15, 15, 7 },
                    { 14, 14, 19 },
                    { 13, 13, 9 },
                    { 12, 12, 8 },
                    { 11, 11, 2 },
                    { 10, 10, 12 },
                    { 9, 9, 13 },
                    { 8, 8, 10 },
                    { 7, 7, 6 },
                    { 6, 6, 0 },
                    { 5, 5, 9 },
                    { 4, 4, 14 },
                    { 3, 3, 6 },
                    { 2, 2, 6 },
                    { 23, 23, 1 },
                    { 49, 49, 13 },
                    { 24, 24, 13 },
                    { 26, 26, 16 },
                    { 47, 47, 12 },
                    { 46, 46, 16 },
                    { 45, 45, 12 },
                    { 44, 44, 14 },
                    { 43, 43, 12 },
                    { 42, 42, 6 },
                    { 41, 41, 9 },
                    { 40, 40, 13 },
                    { 39, 39, 13 },
                    { 38, 38, 19 },
                    { 37, 37, 10 },
                    { 36, 36, 3 },
                    { 35, 35, 19 },
                    { 34, 34, 5 },
                    { 33, 33, 14 },
                    { 32, 32, 2 },
                    { 31, 31, 19 },
                    { 30, 30, 6 },
                    { 29, 29, 0 },
                    { 28, 28, 18 },
                    { 27, 27, 12 },
                    { 25, 25, 10 },
                    { 99, 99, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
