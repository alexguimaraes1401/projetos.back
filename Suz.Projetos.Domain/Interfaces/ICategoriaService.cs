using Suz.Projetos.Domain.Dto;
using Suz.Projetos.Domain.Entities;

namespace Suz.Projetos.Domain.Interfaces
{
    public interface ICategoriaService
    {
        Task Create(CreateCategoriaDTO categoria);
        Task<List<Categoria>> GetAllAsync();
    }
}
