using Suz.Projetos.Domain.Dto;
using Suz.Projetos.Domain.Entities;

namespace Suz.Projetos.Domain.Interfaces
{
    public interface ISubcategoriaService
    {
        Task Create(CreateSubcategoriaDTO subcategoriadto);
        Task<List<Subcategoria>> GetAllAsync();
    }
}
