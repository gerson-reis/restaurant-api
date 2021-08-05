using Microsoft.EntityFrameworkCore;
using Restaurant.Domain;
using Restaurant.Repository;
using Restaurant.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace shopify.data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        protected readonly BaseContext context;
        protected DbSet<T> entities;
        string errorMessage = string.Empty;
        public Repository(BaseContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync() => entities.AsEnumerable();

        public virtual async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> where) => entities.Where(where).AsEnumerable();

        public virtual async Task<IEnumerable<T>> GetPageAsync(int limit, int offset, Expression<Func<T, bool>> where = null)
        {
            IQueryable<T> querable = entities;
            if (where != null)
                querable = querable.Where(where);

            return querable.Skip(offset).Take(limit).AsEnumerable();
        }

        public async virtual Task<T> GetFirstAsync(Expression<Func<T, bool>> where) => await entities.FirstOrDefaultAsync(where);

        public virtual async Task<T> GetById(int id) => entities.SingleOrDefault(s => s.Id == id);

        public virtual async Task<T> InsertAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity is null");
            await entities.AddAsync(entity);
            context.SaveChanges();
            return entity;
        }

        public virtual async Task<IEnumerable<T>> InsertAsync(IEnumerable<T> entity)
        {
            foreach (var model in entity)
            {
                await entities.AddAsync(model);
            }
            context.SaveChanges();
            return entity;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity is null");
            context.Update(entity);
            context.SaveChanges();
            return entity;
        }

        public virtual async Task DeleteAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity is null");
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
