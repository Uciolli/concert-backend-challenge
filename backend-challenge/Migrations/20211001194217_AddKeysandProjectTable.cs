using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend_challenge.Migrations
{
    public partial class AddKeysandProjectTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projetos",
                columns: table => new
                {
                    id_projeto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data_criacao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data_termino = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gerenteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetos", x => x.id_projeto);
                    table.ForeignKey(
                        name: "FK_Projetos_Empregados_gerenteId",
                        column: x => x.gerenteId,
                        principalTable: "Empregados",
                        principalColumn: "id_empregado",
                        onDelete: ReferentialAction.SetNull);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Projetos",
                columns: new[] { "id_projeto", "data_criacao", "data_termino", "gerenteId", "nome" },
                values: new object[,]
                {
                    { 1, "1998-09-08", "NULL", 5, "Google" },
                    { 2, "1991-01-01", "NULL", 3, "Linux" },
                    { 3, "2001-01-01", "NULL", 4, "Wikipedia" },
                    { 4, "2015-09-14", "NULL", 5, "CRM" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_gerenteId",
                table: "Projetos",
                column: "gerenteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projetos");
        }
    }
}
