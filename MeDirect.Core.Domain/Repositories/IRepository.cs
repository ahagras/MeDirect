using System.Linq.Expressions;

namespace MeDirect.Core.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity?> FindById(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<TEntity>> Filter(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken);
        Task Add(TEntity entity, CancellationToken cancellationToken);
        Task AddRange(IEnumerable<TEntity> entities, CancellationToken cancellationToken);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
