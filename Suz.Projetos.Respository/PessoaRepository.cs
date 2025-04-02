using Microsoft.EntityFrameworkCore;
using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.Respository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly DbContext _dbContext;
        public PessoaRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SaveAsync(Pessoa pessoa)
        {
            _dbContext.Set<Pessoa>().Add(pessoa);
            await _dbContext.SaveChangesAsync();
        }

        public Task<List<Pessoa>> GetAllAsync()
        {
            return _dbContext.Set<Pessoa>().ToListAsync();
        }
    }
}
