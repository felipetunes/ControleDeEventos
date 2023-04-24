using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeEventos.Migrations
{
    /// <inheritdoc />
    public partial class Eventos7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Local",
                table: "Eventos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Local",
                table: "Eventos");
        }
    }
}
