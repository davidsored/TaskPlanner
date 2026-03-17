using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskPlanner.API.Migrations
{
    /// <inheritdoc />
    public partial class AgregarFechasExcluidas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FechasExcluidas",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechasExcluidas",
                table: "Tareas");
        }
    }
}
