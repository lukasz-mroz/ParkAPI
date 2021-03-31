using System;
using System.Collections.Generic;
using System.Linq;

namespace Parks.Cores
{
  public interface IRepositoryBase<T>
  {
    IEnumerable<T> GetAll();
    IEnumerable<T> GetOne(Guid id);
    void Create(T entity);
    void Update(Guid id);
    void Delete(Guid id);
  }
}