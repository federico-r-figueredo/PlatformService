
using System.Linq.Expressions;
using PlatformService.Models;

namespace PlatformService.Data.Repositories;

public interface IRepository<TEntity> where TEntity : class, IEntity
{
    // Read
    TEntity Get(int id);
    IEnumerable<TEntity> GetAll();
    IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

    // Create
    void Add(TEntity entity);
    void AddRange(IEnumerable<TEntity> entities);

    // Delete
    void Remove(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entities);
}