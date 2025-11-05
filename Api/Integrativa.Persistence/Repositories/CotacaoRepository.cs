using Integrativa.Domain.Entities;
using Integrativa.Domain.Interfaces;
using Integrativa.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrativa.Persistence.Repositories
{
    internal class CotacaoRepository : BaseRepository<Cotacao>, ICotacaoRepository
    {
        public CotacaoRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Cotacao> ObterPorMenorPreco()
        {
            var menorCotacao = await DbContext.Cotacoes
                .OrderBy(x => x.Preco)
                .FirstOrDefaultAsync();
            return menorCotacao;
        }
    }
}
