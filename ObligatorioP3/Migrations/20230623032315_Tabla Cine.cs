using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ObligatorioP3.Migrations
{
    public partial class TablaCine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proyecciones_Salas_idSala",
                table: "proyecciones");

            migrationBuilder.DropIndex(
                name: "IX_proyecciones_idSala",
                table: "proyecciones");

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
                name: "CineId",
                table: "proyecciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CineId",
                table: "Peliculas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cine",
                columns: table => new
                {
                    id_cine = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_cine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dir_cine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cine", x => x.id_cine);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CineId",
                table: "Usuarios",
                column: "CineId");

            migrationBuilder.CreateIndex(
                name: "IX_Salas_CineId",
                table: "Salas",
                column: "CineId");

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
                name: "FK_Usuarios_Cine_CineId",
                table: "Usuarios",
                column: "CineId",
                principalTable: "Cine",
                principalColumn: "id_cine");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_Usuarios_Cine_CineId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Cine");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_CineId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Salas_CineId",
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
                name: "CineId",
                table: "proyecciones");

            migrationBuilder.DropColumn(
                name: "CineId",
                table: "Peliculas");

            migrationBuilder.CreateIndex(
                name: "IX_proyecciones_idSala",
                table: "proyecciones",
                column: "idSala");

            migrationBuilder.AddForeignKey(
                name: "FK_proyecciones_Salas_idSala",
                table: "proyecciones",
                column: "idSala",
                principalTable: "Salas",
                principalColumn: "id_Sala",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
