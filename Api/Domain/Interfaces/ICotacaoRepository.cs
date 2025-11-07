using Cotacao.Domain.Entities;

namespace Cotacao.Domain.Interfaces
{
    public interface ICotacaoRepository : IBaseRepository<CotacaoEntity>
    {
        Task<CotacaoEntity> ObterPorMenorPreco();
    }
}
