using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ampare_backend.Migrations
{
    public partial class allDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastro",
                columns: table => new
                {
                    IdCadastro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastro", x => x.IdCadastro);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ongs",
                columns: table => new
                {
                    IdCadastro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ongs", x => x.IdCadastro);
                    table.ForeignKey(
                        name: "FK_Ongs_Cadastro_IdCadastro",
                        column: x => x.IdCadastro,
                        principalTable: "Cadastro",
                        principalColumn: "IdCadastro");
                });

            migrationBuilder.CreateTable(
                name: "Voluntarios",
                columns: table => new
                {
                    IdCadastro = table.Column<int>(type: "int", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voluntarios", x => x.IdCadastro);
                    table.ForeignKey(
                        name: "FK_Voluntarios_Cadastro_IdCadastro",
                        column: x => x.IdCadastro,
                        principalTable: "Cadastro",
                        principalColumn: "IdCadastro");
                });

            migrationBuilder.CreateTable(
                name: "Projetos",
                columns: table => new
                {
                    IdProjeto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CadastroOngIdCadastro = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Projetos_Ongs_CadastroOngIdCadastro",
                        column: x => x.CadastroOngIdCadastro,
                        principalTable: "Ongs",
                        principalColumn: "IdCadastro");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_CadastroOngIdCadastro",
                table: "Projetos",
                column: "CadastroOngIdCadastro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadastroVoluntarioProjeto");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Projetos");

            migrationBuilder.DropTable(
                name: "Voluntarios");

            migrationBuilder.DropTable(
                name: "Ongs");

            migrationBuilder.DropTable(
                name: "Cadastro");
        }
    }
}
