using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "Armas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 237, 20, 101, 236, 20, 148, 247, 129, 52, 100, 33, 146, 129, 183, 167, 104, 245, 32, 117, 166, 235, 180, 195, 109, 38, 46, 102, 168, 72, 237, 1, 12, 72, 84, 154, 182, 221, 41, 134, 100, 76, 224, 4, 87, 22, 30, 158, 233, 6, 144, 230, 98, 86, 159, 65, 104, 6, 125, 184, 104, 141, 189, 110, 129 }, new byte[] { 11, 202, 192, 75, 223, 88, 11, 35, 114, 242, 244, 225, 225, 222, 191, 34, 143, 15, 247, 230, 41, 206, 30, 31, 222, 205, 163, 122, 122, 213, 157, 195, 145, 102, 48, 111, 35, 124, 143, 8, 107, 167, 132, 149, 107, 147, 117, 249, 19, 130, 66, 93, 2, 116, 197, 86, 49, 30, 74, 209, 183, 245, 227, 100, 0, 232, 87, 60, 240, 198, 51, 98, 84, 55, 204, 73, 69, 239, 73, 233, 17, 93, 192, 88, 95, 171, 119, 52, 108, 67, 183, 4, 230, 32, 202, 224, 108, 228, 238, 48, 3, 84, 169, 146, 63, 253, 230, 48, 135, 38, 21, 122, 109, 208, 39, 36, 75, 66, 113, 166, 228, 153, 254, 87, 142, 67, 167, 148 } });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas");

            migrationBuilder.DropIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "Armas");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 246, 21, 14, 161, 58, 177, 13, 249, 103, 51, 120, 8, 78, 246, 16, 114, 136, 21, 181, 109, 139, 83, 116, 79, 175, 169, 186, 103, 52, 235, 179, 88, 213, 12, 164, 74, 208, 47, 89, 171, 6, 176, 164, 168, 188, 176, 165, 113, 76, 240, 41, 6, 1, 115, 91, 35, 255, 149, 54, 90, 195, 138, 121, 180 }, new byte[] { 138, 185, 24, 149, 30, 36, 173, 51, 36, 23, 135, 95, 254, 145, 0, 176, 112, 138, 125, 160, 156, 229, 238, 123, 83, 24, 147, 187, 222, 119, 97, 3, 181, 172, 197, 133, 45, 191, 130, 88, 197, 223, 184, 55, 206, 30, 75, 56, 219, 63, 170, 109, 176, 220, 206, 25, 199, 47, 119, 122, 82, 233, 174, 71, 103, 47, 116, 188, 247, 212, 209, 15, 237, 1, 118, 69, 218, 225, 214, 126, 179, 62, 33, 44, 205, 39, 62, 108, 251, 197, 173, 212, 215, 164, 117, 138, 124, 106, 194, 214, 186, 245, 113, 83, 24, 141, 93, 226, 53, 200, 246, 160, 238, 217, 34, 180, 33, 245, 6, 209, 216, 218, 33, 79, 69, 86, 186, 210 } });
        }
    }
}
