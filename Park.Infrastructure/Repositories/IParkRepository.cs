using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Parks.Cores
{
  public interface IParkRepository
  {
    Task<IEnumerable<Parky>> GetAllParks();
    Task<Parky> GetPark(Guid parkId);
    Task CreatePark(Parky park);
    void UpdatePark(Parky park);
    bool ParkExists(Guid parkId);
    void DeletePark(Guid parkId);
    bool Save();
  }
}