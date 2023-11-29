using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ampare_backend.Migrations
{
    public partial class criartabelaprojetovoluntario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjetoVoluntario",
                columns: table => new
                {
                    ProjetoVoluntarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProjeto = table.Column<int>(type: "int", nullable: false),
                    IdVoluntario = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetoVoluntario", x => x.ProjetoVoluntarioId);
                    table.ForeignKey(
                        name: "FK_ProjetoVoluntario_Projetos_IdProjeto",
                        column: x => x.IdProjeto,
                        principalTable: "Projetos",
                        principalColumn: "IdProjeto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjetoVoluntario_Voluntarios_IdVoluntario",
                        column: x => x.IdVoluntario,
                        principalTable: "Voluntarios",
                        principalColumn: "IdCadastro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoVoluntario_IdProjeto",
                table: "ProjetoVoluntario",
                column: "IdProjeto");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoVoluntario_IdVoluntario",
                table: "ProjetoVoluntario",
                column: "IdVoluntario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjetoVoluntario");
        }
    }
}
