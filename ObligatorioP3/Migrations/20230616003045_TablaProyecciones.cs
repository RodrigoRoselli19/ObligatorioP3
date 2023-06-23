using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ObligatorioP3.Migrations
{
    public partial class TablaProyecciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Peliculas",
                newName: "Titulo_Pel");

            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "Peliculas",
                newName: "Genero_Pel");

            migrationBuilder.AlterColumn<string>(
                name: "Des_Pel",
                table: "Peliculas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo_Pel",
                table: "Peliculas",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Genero_Pel",
                table: "Peliculas",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    IdSala = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NroSala = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    SalasIdSala = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.IdSala);
                    table.ForeignKey(
                        name: "FK_Salas_Salas_SalasIdSala",
                        column: x => x.SalasIdSala,
                        principalTable: "Salas",
                        principalColumn: "IdSala");
                });

            migrationBuilder.CreateTable(
                name: "proyecciones",
                columns: table => new
                {
                    ProyeccionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idPelicula = table.Column<int>(type: "int", nullable: false),
                    FechayHora = table.Column<DateTime>(type: "datetime", nullable: true),
                    idSala = table.Column<int>(type: "int", nullable: false),
                    ProyeccionesProyeccionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proyecciones", x => x.ProyeccionId);
                    table.ForeignKey(
                        name: "FK_proyecciones_Peliculas_idPelicula",
                        column: x => x.idPelicula,
                        principalTable: "Peliculas",
                        principalColumn: "PeliculasId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_proyecciones_proyecciones_ProyeccionesProyeccionId",
                        column: x => x.ProyeccionesProyeccionId,
                        principalTable: "proyecciones",
                        principalColumn: "ProyeccionId");
                    table.ForeignKey(
                        name: "FK_proyecciones_Salas_idSala",
                        column: x => x.idSala,
                        principalTable: "Salas",
                        principalColumn: "IdSala",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_proyecciones_idPelicula",
                table: "proyecciones",
                column: "idPelicula");

            migrationBuilder.CreateIndex(
                name: "IX_proyecciones_idSala",
                table: "proyecciones",
                column: "idSala");

            migrationBuilder.CreateIndex(
                name: "IX_proyecciones_ProyeccionesProyeccionId",
                table: "proyecciones",
                column: "ProyeccionesProyeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Salas_SalasIdSala",
                table: "Salas",
                column: "SalasIdSala");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "proyecciones");

            migrationBuilder.DropTable(
                name: "Salas");

            migrationBuilder.RenameColumn(
                name: "Titulo_Pel",
                table: "Peliculas",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "Genero_Pel",
                table: "Peliculas",
                newName: "Genero");

            migrationBuilder.AlterColumn<string>(
                name: "Des_Pel",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Genero",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);
        }
    }
}
