using System;
using System.Linq;
using ParkAPI.DataContext;

namespace Parks.Cores
{
  public abstract class RepositoryBase<T> : IRepositoryBase<T> where T: class
  {
    protected ParkDbContext _dbContext;

    public RepositoryBase(ParkDbContext dbContext)
    {
      _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    public IQueryable<T> GetAll()
    {
      throw new System.NotImplementedException();
    }

    public IQueryable<T> GetOne()
    {
      throw new System.NotImplementedException();
    }

    public void Create(T entity) => _dbContext.Set<T>().Add(entity);
    
  }
}