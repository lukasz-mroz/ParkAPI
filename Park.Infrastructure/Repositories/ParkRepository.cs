using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParkAPI.DataContext;

namespace Parks.Cores
{
  public class ParkRepository : RepositoryBase<Parky>, IParkRepository
  {
    public ParkRepository(ParkDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<IEnumerable<Parky>> GetParks()
    {
      var parkFromDb = await _dbContext.Parks.ToListAsync();
      return parkFromDb;
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

    public void UpdatePark(Parky park)
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