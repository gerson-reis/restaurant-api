using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Repository.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> InsertAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IEnumerable<T>> InsertAsync(IEnumerable<T> entities);
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetFirstAsync(Expression<Func<T, bool>> where);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> where);
    }
}
