using System.ComponentModel.DataAnnotations.Schema;

namespace Cotacao.Domain.Entities
{
    public sealed class Fornecedor : BaseEntity
    {
        [Column("cnpj")]
        public string Cnpj { get; set; }
    }
}
