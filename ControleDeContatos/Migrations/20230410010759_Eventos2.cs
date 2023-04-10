using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeEventos.Migrations
{
    /// <inheritdoc />
    public partial class Eventos2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Eventos");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Eventos",
                newName: "Descricao");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Eventos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Eventos");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Eventos",
                newName: "Email");

            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "Eventos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
