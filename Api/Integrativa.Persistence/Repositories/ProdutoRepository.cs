using Integrativa.Domain.Interfaces;
using Integrativa.Domain.Entities;
using Integrativa.Persistence.Context;

namespace Integrativa.Persistence.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
