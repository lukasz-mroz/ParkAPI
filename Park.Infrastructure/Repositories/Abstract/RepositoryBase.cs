using System.Linq;
using ParkAPI.DataContext;

namespace Parks.Cores
{
  abstract public class RepositoryBase<T> : IRepositoryBase<T> where T: class
  {
    protected ParkDbContext _dbContext;

    public RepositoryBase(ParkDbContext dbContext)
    {
       _dbContext = dbContext;
    }

    public IQueryable<T> GetAll()
    {
      throw new System.NotImplementedException();
    }

    public IQueryable<T>
    {
      throw new System.NotImplementedException();
    }
  }
}