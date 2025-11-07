using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontEnd.Models
{
    public class CotacaoDTO
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int FornecedorId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string NomeFornecedor { get; set; }
        public string NomeProduto { get; set; }
    }
}