using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demos.HomeWork.Migrations
{
    /// <inheritdoc />
    public partial class Vertion2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "_Roles",
                newName: "RolesName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RolesName",
                table: "_Roles",
                newName: "Name");
        }
    }
}
