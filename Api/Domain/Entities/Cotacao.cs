
namespace Integrativa.Domain.Entities
{
    public sealed class Cotacao : BaseEntity
    {
        public DateTime Data { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Produto Produto { get; set; }
        public decimal Preco { get; set; }
    }
}
