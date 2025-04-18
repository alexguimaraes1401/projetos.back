using Suz.Projetos.Domain.Entities;

namespace Suz.Projetos.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        Task SaveAsync(Categoria categoria);
        Task<List<Categoria>> GetAllAsync();
    }
}
