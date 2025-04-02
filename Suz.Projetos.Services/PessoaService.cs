using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.Service
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public Task Create(Pessoa pessoa)
        {
            return _pessoaRepository.SaveAsync(pessoa);
        }

        public Task<List<Pessoa>> GetAllAsync()
        {
            return _pessoaRepository.GetAllAsync();
        }
    }
}
