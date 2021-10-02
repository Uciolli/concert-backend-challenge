using Microsoft.EntityFrameworkCore.Migrations;

namespace backend_challenge.Migrations
{
    public partial class NtoNtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "Membros",
                columns: table => new
                {
                    id_empregado = table.Column<int>(type: "int", nullable: false),
                    id_projeto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membros", x => new { x.id_empregado, x.id_projeto });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EmpregadoMembro",
                columns: table => new
                {
                    Empregadosid_empregado = table.Column<int>(type: "int", nullable: false),
                    Membrosid_empregado = table.Column<int>(type: "int", nullable: false),
                    Membrosid_projeto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpregadoMembro", x => new { x.Empregadosid_empregado, x.Membrosid_empregado, x.Membrosid_projeto });
                    table.ForeignKey(
                        name: "FK_EmpregadoMembro_Empregados_Empregadosid_empregado",
                        column: x => x.Empregadosid_empregado,
                        principalTable: "Empregados",
                        principalColumn: "id_empregado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpregadoMembro_Membros_Membrosid_empregado_Membrosid_projeto",
                        columns: x => new { x.Membrosid_empregado, x.Membrosid_projeto },
                        principalTable: "Membros",
                        principalColumns: new[] { "id_empregado", "id_projeto" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MembroProjeto",
                columns: table => new
                {
                    Projetosid_projeto = table.Column<int>(type: "int", nullable: false),
                    Membrosid_empregado = table.Column<int>(type: "int", nullable: false),
                    Membrosid_projeto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembroProjeto", x => new { x.Projetosid_projeto, x.Membrosid_empregado, x.Membrosid_projeto });
                    table.ForeignKey(
                        name: "FK_MembroProjeto_Membros_Membrosid_empregado_Membrosid_projeto",
                        columns: x => new { x.Membrosid_empregado, x.Membrosid_projeto },
                        principalTable: "Membros",
                        principalColumns: new[] { "id_empregado", "id_projeto" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MembroProjeto_Projetos_Projetosid_projeto",
                        column: x => x.Projetosid_projeto,
                        principalTable: "Projetos",
                        principalColumn: "id_projeto",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_EmpregadoMembro_Membrosid_empregado_Membrosid_projeto",
                table: "EmpregadoMembro",
                columns: new[] { "Membrosid_empregado", "Membrosid_projeto" });

            migrationBuilder.CreateIndex(
                name: "IX_MembroProjeto_Membrosid_empregado_Membrosid_projeto",
                table: "MembroProjeto",
                columns: new[] { "Membrosid_empregado", "Membrosid_projeto" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpregadoMembro");

            migrationBuilder.DropTable(
                name: "MembroProjeto");

            migrationBuilder.DropTable(
                name: "Membros");

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_gerenteId",
                table: "Projetos",
                column: "gerenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Empregados_gerenteId",
                table: "Projetos",
                column: "gerenteId",
                principalTable: "Empregados",
                principalColumn: "id_empregado",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
