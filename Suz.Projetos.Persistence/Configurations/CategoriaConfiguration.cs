using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Suz.Projetos.Domain.Entities;

namespace Suz.Projetos.Persistence.Configurations
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(c => c.Subcategorias)
                .WithOne(sc => sc.Categoria)
                .HasForeignKey(sc => sc.CategoriaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
