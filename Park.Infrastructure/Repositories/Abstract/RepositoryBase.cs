using System;
using System.Collections.Generic;
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

    public IEnumerable<T> GetAll()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<T> GetOne(Guid id)
    {
      throw new NotImplementedException();
    }

    public void Create(T entity)
    {
      throw new NotImplementedException();
    }
    public void Update(Guid id)
    {
      throw new NotImplementedException();
    }

    public void Delete(Guid id)
    {
      throw new NotImplementedException();
    }
  }
}