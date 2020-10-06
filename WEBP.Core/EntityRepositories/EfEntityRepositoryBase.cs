using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WEBP.Core.Entities;

namespace WEBP.Core.EntityRepositories
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public async Task<bool> AddAsync(TEntity Entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(Entity);
                addedEntity.State = EntityState.Added;
                var changes = await context.SaveChangesAsync();
                return changes > 0;
            }
        }

        public async Task<bool> DeleteAsync(TEntity Entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(Entity);
                deletedEntity.State = EntityState.Deleted;
                var changes = await context.SaveChangesAsync();
                return changes > 0;
            }
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().SingleOrDefaultAsync(filter);
            }
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                ? await context.Set<TEntity>().ToListAsync()
                : await context.Set<TEntity>().Where(filter).ToListAsync();
            }
        }

        public async Task<List<TEntity>> GetListAsync(int take, int skip, Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                ? await context.Set<TEntity>().Skip(skip).Take(take).ToListAsync()
                : await context.Set<TEntity>().Where(filter).Skip(skip).Take(take).ToListAsync();
            }
        }

        public async Task<bool> UpdateAsync(TEntity Entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(Entity);
                updatedEntity.State = EntityState.Modified;
                var changes = await context.SaveChangesAsync();
                return changes > 0;
            }
        }

        public async Task<int> GetRowCountAsync()
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().CountAsync();
            }
        }
    }
}
