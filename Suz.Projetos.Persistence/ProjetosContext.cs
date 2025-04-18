using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Persistence.Configurations;

namespace Suz.Projetos.Persistence
{
    public class ProjetosContext : DbContext
    {
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Subcategoria> Subcategorias { get; set; }

        public ProjetosContext(DbContextOptions<ProjetosContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            builder.ApplyConfiguration(new PessoaConfiguration());
            builder.ApplyConfiguration(new ProjetoConfiguration());
            builder.ApplyConfiguration(new CategoriaConfiguration());
            builder.ApplyConfiguration(new SubcategoriaConfiguration());

            // Exclução em cascata no relacionamento: Categoria > Subcategoria
            builder.Entity<Categoria>()
                .HasMany(c => c.Subcategorias)
                .WithOne(s => s.Categoria)
                .HasForeignKey(s => s.CategoriaId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relacionamento: Projeto > Categoria
            builder.Entity<Projeto>()
                .HasOne(p => p.Categoria)
                .WithMany()
                .HasForeignKey(p => p.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento: Projeto > Subcategoria
            builder.Entity<Projeto>()
                .HasOne(p => p.Subcategoria)
                .WithMany()
                .HasForeignKey(p => p.SubcategoriaId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
