using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arellano_Brandon_Exam1.Migrations
{
    /// <inheritdoc />
    public partial class PrimeaMigrcion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Celular",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    model = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    year = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    precio = table.Column<float>(type: "real", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celular", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ArellanoB",
                columns: table => new
                {
                    nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    edad = table.Column<int>(type: "int", maxLength: 150, nullable: false),
                    altura = table.Column<float>(type: "real", nullable: false),
                    esHombre = table.Column<bool>(type: "bit", nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArellanoB", x => x.nombre);
                    table.ForeignKey(
                        name: "FK_ArellanoB_Celular_Celular",
                        column: x => x.Celular,
                        principalTable: "Celular",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArellanoB_Celular",
                table: "ArellanoB",
                column: "Celular");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArellanoB");

            migrationBuilder.DropTable(
                name: "Celular");
        }
    }
}
