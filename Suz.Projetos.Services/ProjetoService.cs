using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.Service
{
    public class ProjetoService : IProjetoService
    {
        private readonly IProjetoRepository _projetoRepository;
        
        public ProjetoService(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        public Task Create(Projeto projeto)
        {
            return _projetoRepository.SaveAsync(projeto);
        }

        public Task<List<Projeto>> GetAllAsync()
        {
            return _projetoRepository.GetAllAsync();
        }
    }
}
