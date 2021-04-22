using System;
using System.Collections.Generic;
using System.Linq;
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

    public async Task<IEnumerable<Parky>> GetAllParks()
    {
      var parks = await _dbContext.Parks.ToListAsync();
      return parks;
    }

    public async Task<Parky> GetPark(Guid parkId)
    {
      var park = await _dbContext.Parks.Where(a => a.Id == parkId).FirstOrDefaultAsync();
      return park;
    }

    public void CreatePark(Parky park)
    {
      if (park == null)
        throw new ArgumentNullException(nameof(park));
      
      _dbContext.Parks.Add(park);
    }

    public void DeletePark(Guid parkId)
    {
      throw new NotImplementedException();
    }

    public bool Save()
    {
      throw new NotImplementedException();
    }
  }
}