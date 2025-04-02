using Suz.Projetos.Domain.Entities;

namespace Suz.Projetos.Domain.Interfaces
{
    public interface IPessoaService
    {
        Task Create(Pessoa pessoa);
        Task<List<Pessoa>> GetAllAsync();
    }
}
