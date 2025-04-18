using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Suz.Projetos.Domain.Entities;

namespace Suz.Projetos.Persistence.Configurations
{
    public class SubcategoriaConfiguration : IEntityTypeConfiguration<Subcategoria>
    {
        public void Configure(EntityTypeBuilder<Subcategoria> builder)
        {
            builder.HasKey(sc => sc.Id);

            builder.Property(sc => sc.Nome)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
