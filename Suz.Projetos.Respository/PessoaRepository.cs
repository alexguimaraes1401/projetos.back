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

        private bool validaCPF(int CPF)
        {
            if (CPF == 0)
            {
                return false;
            }
            else if (CPF < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public async Task SaveAsync(Pessoa pessoa)
        {
            var resultValidaCPF = validaCPF(pessoa.CPF);
            if (resultValidaCPF)
            {
                _dbContext.Set<Pessoa>().Add(pessoa);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                return;
            }
        }

        public Task<List<Pessoa>> GetAllAsync()
        {
            return _dbContext.Set<Pessoa>().ToListAsync();
        }
    }
}
