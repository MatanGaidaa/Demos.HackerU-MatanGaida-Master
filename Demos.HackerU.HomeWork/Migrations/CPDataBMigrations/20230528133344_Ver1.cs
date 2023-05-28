using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demos.HackerU.HomeWork.Migrations.CPDataBMigrations
{
    /// <inheritdoc />
    public partial class Ver1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoryHW19s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryHW19s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "productHW19s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productHW19s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryHW19ProductHW19",
                columns: table => new
                {
                    CategoriesListId = table.Column<int>(type: "int", nullable: false),
                    ProductsListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryHW19ProductHW19", x => new { x.CategoriesListId, x.ProductsListId });
                    table.ForeignKey(
                        name: "FK_CategoryHW19ProductHW19_categoryHW19s_CategoriesListId",
                        column: x => x.CategoriesListId,
                        principalTable: "categoryHW19s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryHW19ProductHW19_productHW19s_ProductsListId",
                        column: x => x.ProductsListId,
                        principalTable: "productHW19s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryHW19ProductHW19_ProductsListId",
                table: "CategoryHW19ProductHW19",
                column: "ProductsListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryHW19ProductHW19");

            migrationBuilder.DropTable(
                name: "categoryHW19s");

            migrationBuilder.DropTable(
                name: "productHW19s");
        }
    }
}
