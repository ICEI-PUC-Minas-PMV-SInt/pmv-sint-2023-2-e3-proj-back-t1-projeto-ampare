using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ampare_backend.Migrations
{
    public partial class ProjetoVoluntarioManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CadastroVoluntarioProjeto",
                columns: table => new
                {
                    ProjetosIdProjeto = table.Column<int>(type: "int", nullable: false),
                    VoluntariosIdCadastro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroVoluntarioProjeto", x => new { x.ProjetosIdProjeto, x.VoluntariosIdCadastro });
                    table.ForeignKey(
                        name: "FK_CadastroVoluntarioProjeto_Projetos_ProjetosIdProjeto",
                        column: x => x.ProjetosIdProjeto,
                        principalTable: "Projetos",
                        principalColumn: "IdProjeto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CadastroVoluntarioProjeto_Voluntarios_VoluntariosIdCadastro",
                        column: x => x.VoluntariosIdCadastro,
                        principalTable: "Voluntarios",
                        principalColumn: "IdCadastro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CadastroVoluntarioProjeto_VoluntariosIdCadastro",
                table: "CadastroVoluntarioProjeto",
                column: "VoluntariosIdCadastro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadastroVoluntarioProjeto");
        }
    }
}
