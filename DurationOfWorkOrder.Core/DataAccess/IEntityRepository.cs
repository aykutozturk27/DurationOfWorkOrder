using DurationOfWorkOrder.Core.Entities;
using System.Linq.Expressions;

namespace DurationOfWorkOrder.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetList(List<T> entities, Expression<Func<T, bool>> filter = null);
        T Get(List<T> entities, Expression<Func<T, bool>> filter);

        Task<List<T>> GetListAsync(List<T> entities, Expression<Func<T, bool>> filter = null);
        Task<T> GetAsync(List<T> entities, Expression<Func<T, bool>> filter);
    }
}
