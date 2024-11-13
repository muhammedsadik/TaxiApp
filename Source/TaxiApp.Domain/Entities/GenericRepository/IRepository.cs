using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Core.Entities;


namespace TaxiApp.EntityFrameworkCore.Concrete.GenericRepository
{
  public interface IRepository<TEntity>
    where TEntity : class, IEntity, new()
  {
    Task<TEntity> CreateAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task DeleteAsync(Guid id);
    Task DeleteAsync(TEntity entity);
    Task<TEntity> GetAsync(Guid id);
    Task<IList<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null);
    Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter);
    bool IsExist(Expression<Func<TEntity, bool>> filter);


  }
}
