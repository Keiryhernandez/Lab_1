using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab_1.Migrations
{
    /// <inheritdoc />
    public partial class NewCeate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreCompleto",
                table: "Alumnos",
                newName: "Carnet");

            migrationBuilder.AddColumn<int>(
                name: "CantidadMaterias",
                table: "Alumnos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ciclo",
                table: "Alumnos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadMaterias",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "Ciclo",
                table: "Alumnos");

            migrationBuilder.RenameColumn(
                name: "Carnet",
                table: "Alumnos",
                newName: "NombreCompleto");
        }
    }
}
