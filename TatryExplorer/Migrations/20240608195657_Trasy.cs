using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TatryExplorer.Migrations
{
    /// <inheritdoc />
    public partial class Trasy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Trails");

            migrationBuilder.DropColumn(
                name: "MapCoordinates",
                table: "Trails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Trails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MapCoordinates",
                table: "Trails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
