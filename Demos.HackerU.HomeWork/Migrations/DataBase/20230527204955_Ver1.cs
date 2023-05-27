using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demos.HackerU.HomeWork.Migrations.DataBase
{
    /// <inheritdoc />
    public partial class Ver1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "managerEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManagerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_managerEmployees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "categoryEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_categoryEmployees_managerEmployees_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "managerEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_categoryEmployees_ManagerId",
                table: "categoryEmployees",
                column: "ManagerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categoryEmployees");

            migrationBuilder.DropTable(
                name: "managerEmployees");
        }
    }
}
