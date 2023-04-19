using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "FotoPersonagem",
                table: "Personagens",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Personagens",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    DataAcesso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Perfil = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Jogador"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, null });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DataAcesso", "Email", "Foto", "Latitude", "Longitude", "PasswordHash", "PasswordSalt", "Perfil", "Username" },
                values: new object[] { 1, null, "seuEmail@gmail.com", null, -23.520024100000001, -46.596497999999997, new byte[] { 246, 21, 14, 161, 58, 177, 13, 249, 103, 51, 120, 8, 78, 246, 16, 114, 136, 21, 181, 109, 139, 83, 116, 79, 175, 169, 186, 103, 52, 235, 179, 88, 213, 12, 164, 74, 208, 47, 89, 171, 6, 176, 164, 168, 188, 176, 165, 113, 76, 240, 41, 6, 1, 115, 91, 35, 255, 149, 54, 90, 195, 138, 121, 180 }, new byte[] { 138, 185, 24, 149, 30, 36, 173, 51, 36, 23, 135, 95, 254, 145, 0, 176, 112, 138, 125, 160, 156, 229, 238, 123, 83, 24, 147, 187, 222, 119, 97, 3, 181, 172, 197, 133, 45, 191, 130, 88, 197, 223, 184, 55, 206, 30, 75, 56, 219, 63, 170, 109, 176, 220, 206, 25, 199, 47, 119, 122, 82, 233, 174, 71, 103, 47, 116, 188, 247, 212, 209, 15, 237, 1, 118, 69, 218, 225, 214, 126, 179, 62, 33, 44, 205, 39, 62, 108, 251, 197, 173, 212, 215, 164, 117, 138, 124, 106, 194, 214, 186, 245, 113, 83, 24, 141, 93, 226, 53, 200, 246, 160, 238, 217, 34, 180, 33, 245, 6, 209, 216, 218, 33, 79, 69, 86, 186, 210 }, "Admin", "UsuarioAdmin" });

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_UsuarioId",
                table: "Personagens",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personagens_Usuarios_UsuarioId",
                table: "Personagens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personagens_Usuarios_UsuarioId",
                table: "Personagens");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Personagens_UsuarioId",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "FotoPersonagem",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Personagens");
        }
    }
}
