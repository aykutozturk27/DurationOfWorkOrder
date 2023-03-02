using DurationOfWorkOrder.Core.Entities;
using System.Linq.Expressions;

namespace DurationOfWorkOrder.Core.DataAccess.InMemory
{
    public class InMemoryEntityRepositoryBase<T> : IEntityRepository<T>
        where T : class, IEntity, new()
    {
        public T Get(List<T> entities, Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(List<T> entities, Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<T> GetList(List<T> entities, Expression<Func<T, bool>> filter = null)
        {
            return entities;
        }

        public async Task<List<T>> GetListAsync(List<T> entities, Expression<Func<T, bool>> filter = null)
        {
            return await Task.FromResult(entities);
        }
    }
}
