using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gruppe6Oppgave1.Web.Migrations
{
    /// <inheritdoc />
    public partial class LaTilNavnBeskrivOgHoyde : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Altitude",
                table: "Marker",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Marker",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Marker",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Altitude",
                table: "Marker");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Marker");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Marker");
        }
    }
}
