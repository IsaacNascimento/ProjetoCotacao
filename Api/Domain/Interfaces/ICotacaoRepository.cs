using Integrativa.Domain.Entities;

namespace Integrativa.Domain.Interfaces
{
    public interface ICotacaoRepository : IBaseRepository<Cotacao>
    {
        Task<Cotacao> ObterPorMenorPreco();
    }
}
