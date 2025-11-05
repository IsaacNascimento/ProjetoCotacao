using Integrativa.Domain.Entities;

namespace Integrativa.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> Get(int id);
        Task<List<T>> GetAll();
    }
}
