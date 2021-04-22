using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Parks.Cores
{
  public interface IParkRepository
  {
    Task<IEnumerable<Parky>> GetAllParks();
    Task<Parky> GetPark(Guid parkId);
    void CreatePark(Parky park);
    void DeletePark(Guid parkId);
    bool Save();
  }
}