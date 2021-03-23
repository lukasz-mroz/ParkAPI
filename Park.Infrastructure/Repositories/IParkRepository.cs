using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Parks.Cores
{
  public interface IParkRepository
  {
    Task<IEnumerable<Parky>> GetParks();
    IEnumerable<Parky> GetPark(Guid parkId);
    void AddPark(Parky park);
    void Create<T>(T entity);
    void UpdatePark(Parky park);
    void AddParks(IEnumerable<Parky> parks);
    void DeletePark(Parky park);


  }
}