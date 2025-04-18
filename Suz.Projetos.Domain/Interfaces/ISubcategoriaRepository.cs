using Suz.Projetos.Domain.Entities;

namespace Suz.Projetos.Domain.Interfaces
{
    public interface ISubcategoriaRepository
    {
        Task SaveAsync(Subcategoria subcategoria);
        Task<List<Subcategoria>> GetAllAsync();
    }
}
