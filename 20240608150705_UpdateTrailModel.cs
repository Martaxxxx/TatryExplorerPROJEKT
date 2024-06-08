using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TatryExplorer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTrailModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dlugość",
                table: "Trails",
                newName: "Długość");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Długość",
                table: "Trails",
                newName: "Dlugość");
        }
    }
}
