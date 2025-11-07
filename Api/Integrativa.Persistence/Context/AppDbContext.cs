using Microsoft.EntityFrameworkCore;
using Cotacao.Domain.Entities;
    
namespace Cotacao.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Fornecedor> fornecedor { get; set; }
        public DbSet<Produto> produto { get; set; }
        public DbSet<CotacaoEntity> cotacao { get; set; }
    }
}
