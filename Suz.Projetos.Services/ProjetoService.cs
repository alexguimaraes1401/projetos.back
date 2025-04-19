using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;
using Suz.Projetos.Domain.Dto;

namespace Suz.Projetos.Service
{
    public class ProjetoService : IProjetoService
    {
        private readonly IProjetoRepository _projetoRepository;

        public ProjetoService(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        public Task Create(CreateProjetoDTO projetoDto)
        {
            var projeto = new Projeto
            {
                Titulo = projetoDto.TituloProjeto,
                Descricao = projetoDto.DescricaoProjeto,
                CategoriaId = projetoDto.CategoriaId,
                SubcategoriaId = projetoDto.SubcategoriaId,
                DataCriacao = DateTime.UtcNow
            };

            return _projetoRepository.SaveAsync(projeto);
        }

        public Task<List<Projeto>> GetAllAsync()
        {
            return _projetoRepository.GetAllAsync();
        }

        public async Task<List<Projeto>> FiltrarProjetosAsync(int? categoriaId, int? subcategoriaId)
        {
            return await _projetoRepository.FiltrarAsync(categoriaId, subcategoriaId);
        }

    }
}
