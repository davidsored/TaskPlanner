using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskPlanner.API.Migrations
{
    /// <inheritdoc />
    public partial class AñadirRecurrenciaTareas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EsRecurrente",
                table: "Tareas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaFinRecurrencia",
                table: "Tareas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatronDias",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EsRecurrente",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "FechaFinRecurrencia",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "PatronDias",
                table: "Tareas");
        }
    }
}
