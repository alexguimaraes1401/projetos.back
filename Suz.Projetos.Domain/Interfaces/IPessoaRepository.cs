using Suz.Projetos.Domain.Entities;

namespace Suz.Projetos.Domain.Interfaces
{
    public interface IPessoaRepository
    {
        Task SaveAsync(Pessoa pessoa);
        Task<List<Pessoa>> GetAllAsync();
    }
}
