using eStore.Core;

namespace eStore.Data;

public interface IRepository<TEntity> where TEntity: BaseEntity
{
    Task InsertAsync(TEntity entity);
    void Insert(TEntity entity);

    Task InsertAsync(IList<TEntity> entities);
    void Insert(IList<TEntity> entities);
}