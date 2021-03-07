using System;
using System.Collections.Generic;

namespace Parks.Cores
{
  public interface IParkRepository
  {
    IEnumerable<Parky> GetParks(Guid parkId);
    void AddBand();
  }
}