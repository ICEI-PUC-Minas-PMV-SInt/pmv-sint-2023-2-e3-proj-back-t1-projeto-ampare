using Microsoft.EntityFrameworkCore;
using ampare_backend.Models;

namespace ampare_backend.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // DB cadastro
         public DbSet<Cadastro> Cadastros { get; set; }

        // DB Ong
        public DbSet<CadastroOng> CadastroOngs { get; set; }

         //DB Voluntario
        public DbSet<CadastroVoluntario> CadastroVoluntarios { get; set; }

        // DB Projeto
        public DbSet<Projeto> Projetos { get; set; }

        // DB Usuario
        public DbSet<Usuario> Usuarios { get; set; }


        public DbSet<ampare_backend.Models.CadastroVoluntario> CadastroVoluntario { get; set; }

    }
}

