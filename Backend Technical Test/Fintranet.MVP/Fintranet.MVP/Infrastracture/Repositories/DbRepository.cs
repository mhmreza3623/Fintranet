using Fintranet.MVP.Core.Entities;
using Fintranet.MVP.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Fintranet.MVP.Infrastracture.Repositories
{
    public class DbRepository<T> : IDbRepository<T> where T : Entity
    {
        private readonly FintranetSampleDbContext context;
        private DbSet<T> _dbSet;
        public DbRepository(FintranetSampleDbContext applicationDbContext)
        {
            context = applicationDbContext;
            _dbSet = context.Set<T>();

        }

        public T Add(T entity)
        {
            _dbSet.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Udate(T entity)
        {
            _dbSet.Attach(entity);
            var entry = context.Entry(entity);
            entry.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
