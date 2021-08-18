using Alunos.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alunos.Database.Mappings
{
    public class AlunosMapModelConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Alunos").HasKey(p => p.Id).HasName("Id");
            builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
            builder.Property(p => p.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(150);
            builder.Property(p => p.Matricula).HasColumnName("Matricula").IsRequired().HasMaxLength(8);
            builder.Property(p => p.Notas).HasColumnName("Notas").IsRequired();
        }
    }
}