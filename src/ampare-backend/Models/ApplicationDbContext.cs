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
        public DbSet<ampare_backend.Models.CadastroOng> CadastroOng { get; set; }

        //DB Voluntario
        public DbSet<ampare_backend.Models.CadastroVoluntario> CadastroVoluntario { get; set; }

        // DB Projeto
        public DbSet<Projeto> Projetos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CadastroVoluntario>().ToTable("Voluntarios");
            modelBuilder.Entity<CadastroOng>().ToTable("Ongs");
        }
    }
}
