using Integrativa.Domain.Entities;
using Integrativa.Domain.Interfaces;
using Integrativa.Persistence.Context;

namespace Integrativa.Persistence.Repositories
{
    public class FornecedorRepository : BaseRepository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
