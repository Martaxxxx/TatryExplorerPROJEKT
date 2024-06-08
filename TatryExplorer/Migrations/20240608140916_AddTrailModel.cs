using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TatryExplorer.Migrations
{
    /// <inheritdoc />
    public partial class AddTrailModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeToComplete",
                table: "Trails");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "Trails",
                newName: "SocialLink");

            migrationBuilder.RenameColumn(
                name: "LengthKm",
                table: "Trails",
                newName: "Length");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Trails",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "DifficultyLevel",
                table: "Trails",
                newName: "Difficulty");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SocialLink",
                table: "Trails",
                newName: "Photo");

            migrationBuilder.RenameColumn(
                name: "Length",
                table: "Trails",
                newName: "LengthKm");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Trails",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "Difficulty",
                table: "Trails",
                newName: "DifficultyLevel");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "TimeToComplete",
                table: "Trails",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
