using Microsoft.EntityFrameworkCore;
using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.Respository
{
    public class SubcategoriaRepository : ISubcategoriaRepository
    {
        private readonly DbContext _dbContext;
        public SubcategoriaRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SaveAsync(Subcategoria subcategoria)
        {
            _dbContext.Set<Subcategoria>().Add(subcategoria);
            await _dbContext.SaveChangesAsync();
        }

        public Task<List<Subcategoria>> GetAllAsync()
        {
            return _dbContext.Set<Subcategoria>().ToListAsync();
        }
    }
}
