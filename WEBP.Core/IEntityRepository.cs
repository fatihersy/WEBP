using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WEBP.Core.Entities;

namespace WEBP.Core
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task<T> GetAsync(Expression<Func<T, bool>> filter = null);

        Task<List<T>> GetListAsync(Expression<Func<T, bool>> filter = null);

        Task<List<T>> GetListAsync(int take, int skip, Expression<Func<T, bool>> filter = null);

        Task<bool> AddAsync(T Entity);

        Task<bool> UpdateAsync(T Entity);

        Task<bool> DeleteAsync(T Entity);

        Task<int> GetRowCountAsync();
    }
}
