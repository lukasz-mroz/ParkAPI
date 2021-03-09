using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ParkAPI.DataContext;

namespace Parks.Cores
{
  //TODO add abstract class generic 
  public class ParkRepository : IParkRepository
  {
    private readonly ParkDbContext _dbContext;

    public ParkRepository(ParkDbContext dbContext)
    {
      _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }


    public IEnumerable<Parky> GetParks()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Parky> GetPark(Guid parkId)
    {
      if (parkId == null)
        throw new ArgumentNullException(nameof(parkId));

      return _dbContext.Parks.Where(a => a.Id == parkId).ToList();
    }

    public void AddPark(Parky park)
    {
      if (park == null)
        throw new ArgumentNullException(nameof(park));

      _dbContext.Parks.Add(park);
    }

    public void UpdatePark(Guid parkId)
    {
      throw new NotImplementedException();
    }

    public void AddParks(IEnumerable<Parky> parks)
    {
      throw new NotImplementedException();
    }

    public void DeletePark(Parky parky)
    {
      if (parky == null)
        throw new ArgumentNullException(nameof(parky));

      _dbContext.Parks.Remove(parky);
    }
  }
}