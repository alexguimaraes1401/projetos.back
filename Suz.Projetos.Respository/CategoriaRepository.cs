using Microsoft.EntityFrameworkCore;
using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.Respository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly DbContext _dbContext;
        public CategoriaRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SaveAsync(Categoria categoria)
        {
            _dbContext.Set<Categoria>().Add(categoria);
            await _dbContext.SaveChangesAsync();
        }

        public Task<List<Categoria>> GetAllAsync()
        {
            return _dbContext.Set<Categoria>().ToListAsync();
        }
    }
}
