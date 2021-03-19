using System.Linq;

namespace Parks.Cores
{
  public interface IRepositoryBase<T>
  {
    IQueryable<T> GetAll();
    IQueryable<T> 
  }
}