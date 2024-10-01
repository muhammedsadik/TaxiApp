using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Domain.Shared.Entities;
//using TaxiApp.Domain.Shared.Entities;

namespace TaxiApp.EntityFrameworkCore.Concrete.EntityFrameworkCore.GenericRepository
{
  public interface IRepository<TEntity, TKey> where TEntity : class, IEntity, new()
  {
    Task<TEntity> CreateAsync(TEntity entity);  
    Task<TEntity> UpdateAsync(TKey id, TEntity entity);
    Task<TEntity> GetAsync(TKey id);
    Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter);
    Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null);
    Task DeleteAsync(TKey id);

  }
}
