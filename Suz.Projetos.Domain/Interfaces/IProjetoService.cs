using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Suz.Projetos.Domain.Entities;

namespace Suz.Projetos.Domain.Interfaces
{
    public interface IProjetoService
    {
        Task Create(Projeto projeto);
        Task<List<Projeto>> GetAllAsync();
    }
}
