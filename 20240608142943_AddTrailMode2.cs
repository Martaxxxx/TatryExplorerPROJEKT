using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TatryExplorer.Migrations
{
    /// <inheritdoc />
    public partial class AddTrailMode2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Trails");

            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "Trails");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Trails");

            migrationBuilder.RenameColumn(
                name: "SocialLink",
                table: "Trails",
                newName: "OpisSzlaku");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Trails",
                newName: "Nazwa");

            migrationBuilder.RenameColumn(
                name: "MapLink",
                table: "Trails",
                newName: "ImagePath");

            migrationBuilder.RenameColumn(
                name: "Length",
                table: "Trails",
                newName: "Longitude");

            migrationBuilder.AddColumn<double>(
                name: "Dlugość",
                table: "Trails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Trails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "PoziomTrudności",
                table: "Trails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dlugość",
                table: "Trails");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Trails");

            migrationBuilder.DropColumn(
                name: "PoziomTrudności",
                table: "Trails");

            migrationBuilder.RenameColumn(
                name: "OpisSzlaku",
                table: "Trails",
                newName: "SocialLink");

            migrationBuilder.RenameColumn(
                name: "Nazwa",
                table: "Trails",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Trails",
                newName: "Length");

            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "Trails",
                newName: "MapLink");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Trails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Difficulty",
                table: "Trails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Trails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
