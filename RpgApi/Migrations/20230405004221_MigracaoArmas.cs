using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoArmas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Personagens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Armas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 62, "Bazuca" },
                    { 2, 3000, "Bomba nuclear" },
                    { 3, 16, "Pistola" },
                    { 4, 24, "Rifle" },
                    { 5, 54, "Sniper" },
                    { 6, 10, "Faca" },
                    { 7, 50, "Granada" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armas");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Personagens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
