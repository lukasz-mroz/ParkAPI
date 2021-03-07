using System.Collections.Generic;

namespace Parks.Cores
{
  public interface IParkRepository
  {
    IEnumerable<Parky> GetBand();
    void AddBand();
  }
}