using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ObligatorioP3.Migrations
{
    public partial class CreacionReservas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peliculas_Cine_CineId",
                table: "Peliculas");

            migrationBuilder.DropForeignKey(
                name: "FK_proyecciones_Cine_CineId",
                table: "proyecciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Salas_Cine_CineId",
                table: "Salas");

            migrationBuilder.DropForeignKey(
                name: "FK_Salas_proyecciones_ProyeccionesProyeccionId",
                table: "Salas");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Cine_CineId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_CineId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Salas_CineId",
                table: "Salas");

            migrationBuilder.DropIndex(
                name: "IX_Salas_ProyeccionesProyeccionId",
                table: "Salas");

            migrationBuilder.DropIndex(
                name: "IX_proyecciones_CineId",
                table: "proyecciones");

            migrationBuilder.DropIndex(
                name: "IX_Peliculas_CineId",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "CineId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CineId",
                table: "Salas");

            migrationBuilder.DropColumn(
                name: "ProyeccionesProyeccionId",
                table: "Salas");

            migrationBuilder.DropColumn(
                name: "CineId",
                table: "proyecciones");

            migrationBuilder.DropColumn(
                name: "CineId",
                table: "Peliculas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CineId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CineId",
                table: "Salas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProyeccionesProyeccionId",
                table: "Salas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CineId",
                table: "proyecciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CineId",
                table: "Peliculas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CineId",
                table: "Usuarios",
                column: "CineId");

            migrationBuilder.CreateIndex(
                name: "IX_Salas_CineId",
                table: "Salas",
                column: "CineId");

            migrationBuilder.CreateIndex(
                name: "IX_Salas_ProyeccionesProyeccionId",
                table: "Salas",
                column: "ProyeccionesProyeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_proyecciones_CineId",
                table: "proyecciones",
                column: "CineId");

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_CineId",
                table: "Peliculas",
                column: "CineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Peliculas_Cine_CineId",
                table: "Peliculas",
                column: "CineId",
                principalTable: "Cine",
                principalColumn: "id_cine");

            migrationBuilder.AddForeignKey(
                name: "FK_proyecciones_Cine_CineId",
                table: "proyecciones",
                column: "CineId",
                principalTable: "Cine",
                principalColumn: "id_cine");

            migrationBuilder.AddForeignKey(
                name: "FK_Salas_Cine_CineId",
                table: "Salas",
                column: "CineId",
                principalTable: "Cine",
                principalColumn: "id_cine");

            migrationBuilder.AddForeignKey(
                name: "FK_Salas_proyecciones_ProyeccionesProyeccionId",
                table: "Salas",
                column: "ProyeccionesProyeccionId",
                principalTable: "proyecciones",
                principalColumn: "ProyeccionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Cine_CineId",
                table: "Usuarios",
                column: "CineId",
                principalTable: "Cine",
                principalColumn: "id_cine");
        }
    }
}
