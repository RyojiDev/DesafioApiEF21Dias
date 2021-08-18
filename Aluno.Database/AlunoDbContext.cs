using Alunos.Database.Mappings;
using Alunos.Domain;
using Microsoft.EntityFrameworkCore;

namespace Alunos.Database
{
    public class AlunosDbContext : DbContext
    {
        public AlunosDbContext(DbContextOptions<AlunosDbContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunosMapModelConfiguration());
        }
    }
}