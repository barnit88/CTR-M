using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Service.Base
{
    public interface IBaseService<T> where T : class
    {
        IEnumerable<T> GetAll();

        Task<IEnumerable<T>> GetAllAsync();

        T GetById(long id);

        Task<T> GetByIdAsync(long id);

        bool Add(T entity);

        Task<bool> AddAsync(T entity);

        bool AddRange(ICollection<T> entities);

        bool Update(T entity);

        bool UpdateRange(ICollection<T> entities);

        bool Remove(T entity);

        bool RemoveRange(ICollection<T> entities);

        int GetCount();

        Task<int> GetCountAsync();

        void Dispose();
    }
}
