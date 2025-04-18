using Suz.Projetos.Domain.Dto;
using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.Service
{
    public class SubcategoriaService : ISubcategoriaService
    {
        private readonly ISubcategoriaRepository _subcategoriaRepository;

        public SubcategoriaService(ISubcategoriaRepository subcategoriaRepository)
        {
            _subcategoriaRepository = subcategoriaRepository;
        }

        public Task Create(CreateSubcategoriaDTO subcategoriadto)
        {
            var subcategoria = new Subcategoria {
                CategoriaId = subcategoriadto.CategoriaId,
                Nome = subcategoriadto.Nome,
            };
            
            return _subcategoriaRepository.SaveAsync(subcategoria);
        }

        public Task<List<Subcategoria>> GetAllAsync()
        {
            return _subcategoriaRepository.GetAllAsync();
        }
    }
}
