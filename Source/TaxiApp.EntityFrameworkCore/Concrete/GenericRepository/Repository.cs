using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Domain.Shared.Entities;

namespace TaxiApp.EntityFrameworkCore.Concrete.GenericRepository
{
  public class Repository<TEntity, TContext> : IRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
  {
    public async Task<TEntity> CreateAsync(TEntity entity)
    {
      using (var context = new TContext())
      {
        await context.Set<TEntity>().AddAsync(entity);
        await context.SaveChangesAsync();
        return entity;
      }
    }

    public async Task DeleteAsync(Guid id)
    {
      using (var context = new TContext())
      {
        await context.Set<TEntity>().Where(x => x.Id == id).ExecuteDeleteAsync();
        await context.SaveChangesAsync();
      }
    }

    public async Task DeleteAsync(TEntity entity)
    {
      using (var context = new TContext())
      {
        context.Set<TEntity>().Remove(entity);
        await context.SaveChangesAsync();
      }
    }

    public async Task<TEntity> GetAsync(Guid id)
    {
      using (var context = new TContext())
      {
        return await context.Set<TEntity>().FindAsync(id);
      }
    }

    public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
    {
      using (var context = new TContext())
      {
        return context.Set<TEntity>().FirstOrDefaultAsync(filter);
      }
    }

    public async Task<IList<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
    {
      using (var context = new TContext())
      {
        return filter == null
          ? await context.Set<TEntity>().ToListAsync()
          : await context.Set<TEntity>().Where(filter).ToListAsync();
      }
    }

    public bool IsExist(Expression<Func<TEntity, bool>> filter)
    {
      using (var context = new TContext())
      {
        return context.Set<TEntity>().Any(filter);
      }
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
      using (var context = new TContext())
      {
        context.Set<TEntity>().Update(entity);
        await context.SaveChangesAsync();

        return entity;
      }
    }

  }
}
