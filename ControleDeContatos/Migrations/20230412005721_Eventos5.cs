using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeEventos.Migrations
{
    /// <inheritdoc />
    public partial class Eventos5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Eventos");

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Eventos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Eventos");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Eventos",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }
    }
}
