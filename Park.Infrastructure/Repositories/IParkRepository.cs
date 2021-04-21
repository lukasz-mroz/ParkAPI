using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Parks.Cores
{
  public interface IParkRepository
  {
    Task<IEnumerable<Parky>> GetAllParks();
  }
}