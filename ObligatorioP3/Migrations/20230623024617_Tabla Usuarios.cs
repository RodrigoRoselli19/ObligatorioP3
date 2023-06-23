using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ObligatorioP3.Migrations
{
    public partial class TablaUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proyecciones_proyecciones_ProyeccionesProyeccionId",
                table: "proyecciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Salas_Salas_SalasIdSala",
                table: "Salas");

            migrationBuilder.DropIndex(
                name: "IX_proyecciones_ProyeccionesProyeccionId",
                table: "proyecciones");

            migrationBuilder.DropColumn(
                name: "ProyeccionesProyeccionId",
                table: "proyecciones");

            migrationBuilder.RenameColumn(
                name: "NroSala",
                table: "Salas",
                newName: "Nro_Sala");

            migrationBuilder.RenameColumn(
                name: "Cantidad",
                table: "Salas",
                newName: "Cant_Sala");

            migrationBuilder.RenameColumn(
                name: "IdSala",
                table: "Salas",
                newName: "id_Sala");

            migrationBuilder.RenameColumn(
                name: "SalasIdSala",
                table: "Salas",
                newName: "ProyeccionesProyeccionId");

            migrationBuilder.RenameIndex(
                name: "IX_Salas_SalasIdSala",
                table: "Salas",
                newName: "IX_Salas_ProyeccionesProyeccionId");

            migrationBuilder.RenameColumn(
                name: "PeliculasId",
                table: "Peliculas",
                newName: "id_Pel");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    mail_usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pass_usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tel_usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id_Usuario);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Salas_proyecciones_ProyeccionesProyeccionId",
                table: "Salas",
                column: "ProyeccionesProyeccionId",
                principalTable: "proyecciones",
                principalColumn: "ProyeccionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salas_proyecciones_ProyeccionesProyeccionId",
                table: "Salas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "Nro_Sala",
                table: "Salas",
                newName: "NroSala");

            migrationBuilder.RenameColumn(
                name: "Cant_Sala",
                table: "Salas",
                newName: "Cantidad");

            migrationBuilder.RenameColumn(
                name: "id_Sala",
                table: "Salas",
                newName: "IdSala");

            migrationBuilder.RenameColumn(
                name: "ProyeccionesProyeccionId",
                table: "Salas",
                newName: "SalasIdSala");

            migrationBuilder.RenameIndex(
                name: "IX_Salas_ProyeccionesProyeccionId",
                table: "Salas",
                newName: "IX_Salas_SalasIdSala");

            migrationBuilder.RenameColumn(
                name: "id_Pel",
                table: "Peliculas",
                newName: "PeliculasId");

            migrationBuilder.AddColumn<int>(
                name: "ProyeccionesProyeccionId",
                table: "proyecciones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_proyecciones_ProyeccionesProyeccionId",
                table: "proyecciones",
                column: "ProyeccionesProyeccionId");

            migrationBuilder.AddForeignKey(
                name: "FK_proyecciones_proyecciones_ProyeccionesProyeccionId",
                table: "proyecciones",
                column: "ProyeccionesProyeccionId",
                principalTable: "proyecciones",
                principalColumn: "ProyeccionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Salas_Salas_SalasIdSala",
                table: "Salas",
                column: "SalasIdSala",
                principalTable: "Salas",
                principalColumn: "IdSala");
        }
    }
}
