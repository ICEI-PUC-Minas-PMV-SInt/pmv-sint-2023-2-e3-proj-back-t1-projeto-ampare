using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ampare_backend.Migrations
{
    public partial class TabelaProjetos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projetos",
                columns: table => new
                {
                    IdProjeto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CadastroOngId = table.Column<int>(type: "int", nullable: true),
                    IdOng = table.Column<int>(type: "int", nullable: false),
                    ResponsavelProjeto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeProjeto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescricaoProjeto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusProjeto = table.Column<bool>(type: "bit", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CidadeProjeto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoProjeto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetos", x => x.IdProjeto);
                    table.ForeignKey(
                        name: "FK_Projetos_CadastroOngs_CadastroOngId",
                        column: x => x.CadastroOngId,
                        principalTable: "CadastroOngs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_CadastroOngId",
                table: "Projetos",
                column: "CadastroOngId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projetos");
        }
    }
}
