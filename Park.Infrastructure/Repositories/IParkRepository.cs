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
    void UpdatePark(Guid parkId);
    void AddParks(IEnumerable<Parky> parks);
    void DeletePark(Parky parkyDeleted);


  }
}