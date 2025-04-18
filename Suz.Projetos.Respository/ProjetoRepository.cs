using Microsoft.EntityFrameworkCore;
using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.Respository
{
    public class ProjetoRepository : IProjetoRepository
    {
        private readonly DbContext _dbContext;

        public ProjetoRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Projeto>> GetAllAsync()
        {
            return _dbContext.Set<Projeto>()
                .Include(p => p.Categoria)
                .Include(p => p.Subcategoria)
                .ToListAsync();
        }

        public async Task SaveAsync(Projeto projeto)
        {
            _dbContext.Set<Projeto>().Add(projeto);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Projeto>> FiltrarAsync(int? categoriaId, int? subcategoriaId)
        {
            var query = _dbContext.Set<Projeto>()
                .Include(p => p.Categoria)
                .Include(p => p.Subcategoria)
                .AsQueryable();

            if (categoriaId.HasValue)
                query = query.Where(p => p.CategoriaId == categoriaId.Value);

            if (subcategoriaId.HasValue)
                query = query.Where(p => p.SubcategoriaId == subcategoriaId.Value);

            return await query.ToListAsync();
        }

    }
}
