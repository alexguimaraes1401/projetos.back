using Microsoft.EntityFrameworkCore;
using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.Respository
{
    public class ProjetoRepository : IProjetoRepository
    {
        private readonly DbContext _dbContext;

        public ProjetoRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Projeto>> GetAllAsync()
        {
            return _dbContext.Set<Projeto>()
                .ToListAsync();
        }

        public async Task SaveAsync(Projeto projeto)
        {
            _dbContext.Set<Projeto>().Add(projeto);
            await _dbContext.SaveChangesAsync();
        }
    }
}
