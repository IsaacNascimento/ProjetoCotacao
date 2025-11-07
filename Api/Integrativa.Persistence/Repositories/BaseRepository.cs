using Microsoft.EntityFrameworkCore;
using Cotacao.Domain.Interfaces;
using Cotacao.Domain.Entities;
using Cotacao.Persistence.Context;

namespace Cotacao.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext DbContext;

        public BaseRepository(AppDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public async Task Create(T entity)
        {
            DbContext.Add<T>(entity);
            await DbContext.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            DbContext.Update<T>(entity);
            await DbContext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            DbContext.Remove<T>(entity);
            await DbContext.SaveChangesAsync();
        }

        public async Task<T> Get(int id)
        {
            return await DbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<T>> GetAll()
        {
            return await DbContext.Set<T>().ToListAsync();
        }
    }
}
