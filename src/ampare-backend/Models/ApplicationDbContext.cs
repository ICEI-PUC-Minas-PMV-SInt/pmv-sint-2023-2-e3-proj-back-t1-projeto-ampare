using Microsoft.EntityFrameworkCore;

namespace ampare_backend.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Cadastro> Cadastros { get; set; }

        public DbSet<CadastroOng> CadastroOngs { get; set; }

        public DbSet<CadastroVoluntario> CadastroVoluntarios { get; set; }

        public DbSet<Projeto> Projetos { get; set; }

        public DbSet<ProjetoVoluntario> ProjetoVoluntarios { get; set; }


    }
}

