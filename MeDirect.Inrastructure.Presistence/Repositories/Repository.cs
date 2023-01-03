using MeDirect.Core.Domain.Repositories;
using MeDirect.Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MeDirect.Inrastructure.Presistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly MeDirectContext dbContext;

        public Repository(MeDirectContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(TEntity entity, CancellationToken cancellationToken)
            => await dbContext.Set<TEntity>().AddAsync(entity, cancellationToken);

        public async Task AddRange(IEnumerable<TEntity> entities, CancellationToken cancellationToken)
           => await dbContext.Set<TEntity>().AddRangeAsync(entities, cancellationToken);

        public async Task<IEnumerable<TEntity>> Filter(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken)
            => await dbContext.Set<TEntity>().Where(expression).ToListAsync();

        public async Task<TEntity?> FindById(Guid id, CancellationToken cancellationToken)
            => await dbContext.Set<TEntity>().FindAsync(id, cancellationToken);

        public void Remove(TEntity entity)
            => dbContext.Set<TEntity>().Remove(entity);

        public void RemoveRange(IEnumerable<TEntity> entities)
            => dbContext.Set<TEntity>().RemoveRange(entities);

    }
}
