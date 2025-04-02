using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Suz.Projetos.Domain.Entities;

namespace Suz.Projetos.Persistence
{
    public class ProjetosContext : DbContext
    {
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }

        public ProjetosContext(DbContextOptions<ProjetosContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
