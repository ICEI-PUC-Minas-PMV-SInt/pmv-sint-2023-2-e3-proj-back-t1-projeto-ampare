using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ampare_backend.Migrations
{
    public partial class removendotabelausuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ongs_Cadastro_IdCadastro",
                table: "Ongs");

            migrationBuilder.DropForeignKey(
                name: "FK_Voluntarios_Cadastro_IdCadastro",
                table: "Voluntarios");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cadastro",
                table: "Cadastro");

            migrationBuilder.RenameTable(
                name: "Cadastro",
                newName: "Cadastros");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cadastros",
                table: "Cadastros",
                column: "IdCadastro");

            migrationBuilder.AddForeignKey(
                name: "FK_Ongs_Cadastros_IdCadastro",
                table: "Ongs",
                column: "IdCadastro",
                principalTable: "Cadastros",
                principalColumn: "IdCadastro");

            migrationBuilder.AddForeignKey(
                name: "FK_Voluntarios_Cadastros_IdCadastro",
                table: "Voluntarios",
                column: "IdCadastro",
                principalTable: "Cadastros",
                principalColumn: "IdCadastro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ongs_Cadastros_IdCadastro",
                table: "Ongs");

            migrationBuilder.DropForeignKey(
                name: "FK_Voluntarios_Cadastros_IdCadastro",
                table: "Voluntarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cadastros",
                table: "Cadastros");

            migrationBuilder.RenameTable(
                name: "Cadastros",
                newName: "Cadastro");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cadastro",
                table: "Cadastro",
                column: "IdCadastro");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Ongs_Cadastro_IdCadastro",
                table: "Ongs",
                column: "IdCadastro",
                principalTable: "Cadastro",
                principalColumn: "IdCadastro");

            migrationBuilder.AddForeignKey(
                name: "FK_Voluntarios_Cadastro_IdCadastro",
                table: "Voluntarios",
                column: "IdCadastro",
                principalTable: "Cadastro",
                principalColumn: "IdCadastro");
        }
    }
}
