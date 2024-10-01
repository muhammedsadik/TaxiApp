using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Domain.Shared.Entities;

namespace TaxiApp.EntityFrameworkCore.Concrete.EntityFrameworkCore.GenericRepository
{
  public class GenericResitory<TEntity, TKey, TContext> : IRepository<TEntity, TKey>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
  {
    public Task<TEntity> CreateAsync(TEntity entity)
    {
      throw new NotImplementedException();
    }

    public Task DeleteAsync(TKey id)
    {
      throw new NotImplementedException();
    }

    public Task<TEntity> GetAsync(TKey id)
    {
      throw new NotImplementedException();
    }

    public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
    {
      throw new NotImplementedException();
    }

    public Task<TEntity> UpdateAsync(TKey id, TEntity entity)
    {
      throw new NotImplementedException();
    }
  }
}
