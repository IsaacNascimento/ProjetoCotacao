using Cotacao.Domain.Entities;
using Cotacao.Domain.Interfaces;
using Cotacao.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Cotacao.Persistence.Repositories
{
    public class CotacaoRepository : BaseRepository<CotacaoEntity>, ICotacaoRepository
    {
        public CotacaoRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<CotacaoEntity> ObterPorMenorPreco()
        {
            var menorCotacao = await DbContext.cotacao
                .OrderBy(x => x.Preco)
                .FirstOrDefaultAsync();
            return menorCotacao;
        }
    }
}
