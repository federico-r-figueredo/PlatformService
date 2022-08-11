
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
{
    protected readonly DbContext _context;

    public Repository(DbContext context)
    {
        _context = context;
    }

    public TEntity Get(int id)
    {
        TEntity? entity = _context.Set<TEntity>().Find(id);

        if (entity == null) throw new Exception($"{nameof(TEntity)} with Id = {id} not found");

        return entity;
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _context.Set<TEntity>().ToList();
    }

    
    public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
    {
        return _context.Set<TEntity>().Where(predicate);
    }

    public void Add(TEntity entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));

        _context.Add(entity);
    }

    public void AddRange(IEnumerable<TEntity> entities)
    {
        _context.AddRange(entities);
    }

    public void Remove(TEntity entity)
    {
        _context.Remove(entity);
    }

    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        _context.RemoveRange(entities);
    }
}