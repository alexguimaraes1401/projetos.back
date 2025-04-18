using Suz.Projetos.Domain.Entities;

namespace Suz.Projetos.Domain.Interfaces
{
    public interface IProjetoRepository
    {
        Task SaveAsync(Projeto projeto);
        Task<List<Projeto>> GetAllAsync();
        Task<List<Projeto>> FiltrarAsync(int? categoriaId, int? subcategoriaId);
    }
}
