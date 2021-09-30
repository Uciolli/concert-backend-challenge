using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend_challenge.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empregados",
                columns: table => new
                {
                    id_empregado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    primeiro_nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ultimo_nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefone = table.Column<int>(type: "int", nullable: false),
                    endereco = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empregados", x => x.id_empregado);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Empregados",
                columns: new[] { "id_empregado", "endereco", "primeiro_nome", "telefone", "ultimo_nome" },
                values: new object[,]
                {
                    { 1, "big.boss@company.com", "Big", 936854270, "BOSS" },
                    { 2, "jonas.xavier@company.com", "Jonas", 936854271, "Xavier" },
                    { 3, "linus.torvalds@company.com", "Linus", 936854272, "TORVALDS" },
                    { 4, "jimmy.wales@company.com", "Jimmy", 936854273, "WALES" },
                    { 5, "larry.page@company.com", "Larry", 936854274, "PAGE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empregados");
        }
    }
}
