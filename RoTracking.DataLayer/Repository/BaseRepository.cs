using Microsoft.EntityFrameworkCore;
using RoTracking.DataLayer.Context;
using RoTracking.DataLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.DataLayer.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly RoTrackingDbContext _roTrackingContext;
        private DbSet<T> dbSet;
        public BaseRepository(RoTrackingDbContext context)
        {
            this._roTrackingContext = context;
            dbSet = context.Set<T>();
        }
        public void Add(T entity)
        {
            _roTrackingContext.Add(entity);
            _roTrackingContext.SaveChanges();
        }
        public async Task AddAsync(T entity)
        {
            await _roTrackingContext.AddAsync(entity);
        }
        public async Task SaveAsync()
        {
            await _roTrackingContext.SaveChangesAsync();
        }

        public T Get(Guid id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query.ToList();
        }
        public void Remove(Guid id)
        {
            dbSet.Remove(Get(id));
            _roTrackingContext.SaveChanges();
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
            _roTrackingContext.SaveChanges();
        }

        public void Save()
        {
            _roTrackingContext.SaveChanges();
        }

    }
}
