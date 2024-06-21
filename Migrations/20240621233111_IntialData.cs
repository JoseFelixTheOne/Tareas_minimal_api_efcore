using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace projectef.Migrations
{
    /// <inheritdoc />
    public partial class IntialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[,]
                {
                    { new Guid("379c2a7e-7f7d-4d28-9ec7-bc4f7eeef102"), null, "Actividades Personales", 50 },
                    { new Guid("379c2a7e-7f7d-4d28-9ec7-bc4f7eeef1fa"), null, "Actividades Pendientes", 20 }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PrioridadTarea", "Titulo" },
                values: new object[,]
                {
                    { new Guid("379c2a7e-7f7d-4d28-9ec7-bc4f7eeef110"), new Guid("379c2a7e-7f7d-4d28-9ec7-bc4f7eeef1fa"), null, new DateTime(2024, 6, 21, 18, 31, 11, 269, DateTimeKind.Local).AddTicks(6768), 2, "Pago de servicios publicos" },
                    { new Guid("379c2a7e-7f7d-4d28-9ec7-bc4f7eeef111"), new Guid("379c2a7e-7f7d-4d28-9ec7-bc4f7eeef102"), null, new DateTime(2024, 6, 21, 18, 31, 11, 269, DateTimeKind.Local).AddTicks(6794), 0, "Terminar de ver pelicula en Netflix" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("379c2a7e-7f7d-4d28-9ec7-bc4f7eeef110"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("379c2a7e-7f7d-4d28-9ec7-bc4f7eeef111"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("379c2a7e-7f7d-4d28-9ec7-bc4f7eeef102"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("379c2a7e-7f7d-4d28-9ec7-bc4f7eeef1fa"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
