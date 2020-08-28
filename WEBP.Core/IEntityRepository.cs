using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WEBP.Core.Entities;

namespace WEBP.Core
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);

        List<T> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T Entity);

        void Update(T Entity);

        void Delete(T Entity);
    }
}
