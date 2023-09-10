using Fintranet.MVP.Core.Entities;
using System.Linq.Expressions;

namespace Fintranet.MVP.Core.Interfaces.Repositories
{
    public interface IDbRepository<T> where T : Entity
    {
        T Add(T entity);
        IQueryable<T> Get(Expression<Func<T, bool>> expression);
        IEnumerable<T> GetAll();
        void Udate(T entity);
    }
}
