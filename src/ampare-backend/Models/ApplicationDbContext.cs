using Microsoft.EntityFrameworkCore;

namespace ampare_backend.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // DB cadastro
        // public DbSet<Cadastro> Cadastros { get; set; }

        // DB Ong
        // public DbSet<CadastroOng> CadastroOngs { get; set; }

        // DB Voluntario
        //public DbSet<CadastroVoluntario> CadastroVoluntarios { get; set; }

        // DB Projeto
        // public DbSet<Projeto> Projetos { get; set; }

        // DB ProjetoVoluntario
        //public DbSet<ProjetoVoluntario> ProjetoVoluntarios { get; set; }

        // DB Usuario
        public DbSet<Usuario> Usuarios { get; set; }


    }
}

