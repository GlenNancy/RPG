using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonagemHabilidades",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemHabilidades", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Habilidades_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "Habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 10, "Ilusão" },
                    { 2, 39, "Desintegrar" },
                    { 3, 24, "Eletreficar" },
                    { 4, 24, "Furacão" },
                    { 5, 54, "Velocidade Super Sonica" }
                });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 119, 213, 26, 44, 253, 216, 77, 74, 208, 82, 14, 173, 97, 121, 31, 241, 1, 99, 60, 73, 107, 110, 169, 228, 232, 152, 156, 77, 183, 171, 170, 132, 155, 88, 114, 9, 31, 237, 73, 218, 203, 189, 117, 58, 220, 248, 137, 31, 41, 4, 209, 97, 238, 8, 241, 253, 46, 108, 32, 71, 117, 248, 232, 88 }, new byte[] { 112, 25, 137, 64, 190, 127, 138, 218, 208, 107, 116, 54, 129, 198, 208, 89, 92, 153, 133, 86, 97, 146, 181, 205, 144, 150, 96, 225, 106, 203, 215, 42, 239, 203, 87, 30, 193, 199, 117, 22, 11, 34, 17, 109, 23, 240, 24, 119, 73, 7, 107, 168, 222, 45, 66, 211, 28, 199, 254, 83, 69, 104, 236, 222, 245, 117, 9, 131, 193, 100, 17, 253, 85, 80, 130, 36, 213, 96, 123, 228, 98, 100, 178, 20, 222, 130, 42, 131, 154, 10, 46, 228, 138, 26, 169, 62, 215, 255, 122, 142, 242, 239, 83, 133, 188, 165, 226, 240, 9, 240, 177, 210, 59, 32, 207, 114, 75, 76, 242, 22, 36, 218, 85, 150, 8, 0, 162, 187 } });

            migrationBuilder.InsertData(
                table: "PersonagemHabilidades",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 5, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemHabilidades_HabilidadeId",
                table: "PersonagemHabilidades",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonagemHabilidades");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "Personagens");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 237, 20, 101, 236, 20, 148, 247, 129, 52, 100, 33, 146, 129, 183, 167, 104, 245, 32, 117, 166, 235, 180, 195, 109, 38, 46, 102, 168, 72, 237, 1, 12, 72, 84, 154, 182, 221, 41, 134, 100, 76, 224, 4, 87, 22, 30, 158, 233, 6, 144, 230, 98, 86, 159, 65, 104, 6, 125, 184, 104, 141, 189, 110, 129 }, new byte[] { 11, 202, 192, 75, 223, 88, 11, 35, 114, 242, 244, 225, 225, 222, 191, 34, 143, 15, 247, 230, 41, 206, 30, 31, 222, 205, 163, 122, 122, 213, 157, 195, 145, 102, 48, 111, 35, 124, 143, 8, 107, 167, 132, 149, 107, 147, 117, 249, 19, 130, 66, 93, 2, 116, 197, 86, 49, 30, 74, 209, 183, 245, 227, 100, 0, 232, 87, 60, 240, 198, 51, 98, 84, 55, 204, 73, 69, 239, 73, 233, 17, 93, 192, 88, 95, 171, 119, 52, 108, 67, 183, 4, 230, 32, 202, 224, 108, 228, 238, 48, 3, 84, 169, 146, 63, 253, 230, 48, 135, 38, 21, 122, 109, 208, 39, 36, 75, 66, 113, 166, 228, 153, 254, 87, 142, 67, 167, 148 } });
        }
    }
}
