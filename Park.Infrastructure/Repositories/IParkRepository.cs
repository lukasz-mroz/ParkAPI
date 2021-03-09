using System;
using System.Collections.Generic;

namespace Parks.Cores
{
  public interface IParkRepository
  {
    IEnumerable<Parky> GetParks();
    IEnumerable<Parky> GetPark(Guid parkId);
    void AddPark(Parky park);
    void UpdatePark(Guid parkId);
    void AddParks(IEnumerable<Parky> parks);
    void DeletePark(Parky parkyDeleted);


  }
}