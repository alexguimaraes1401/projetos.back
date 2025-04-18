using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Dto;

namespace Suz.Projetos.Domain.Interfaces
{
    public interface IProjetoService
    {
        Task Create(CreateProjetoDTO projetoDto);
        Task<List<Projeto>> GetAllAsync();
        Task<List<Projeto>> FiltrarProjetosAsync(int? categoriaId, int? subcategoriaId);
    }
}
