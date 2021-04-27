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
      var parks = await _dbContext.Parks.Where(a => a.IsDeleted == false).ToListAsync();

      return parks;
    }

    public async Task<Parky> GetPark(Guid parkId)
    {
      var park = await _dbContext.Parks.Where(a => a.Id == parkId).FirstOrDefaultAsync();
      
      return park;
    }

    public async Task CreatePark(Parky park)
    {
      if (park == null)
        throw new ArgumentNullException(nameof(park));
      
      await _dbContext.Parks.AddAsync(park);
    }

    public void UpdatePark(Parky park)
    {
      if (park == null)
        throw new ArgumentNullException(nameof(park));

        _dbContext.Parks.Update(park);
    }

    public bool ParkExists(Guid parkId)
    {
      if (parkId == Guid.Empty)
        throw new ArgumentNullException(nameof(parkId));

      return _dbContext.Parks.Any(a => a.Id == parkId);
    }

    public void DeletePark(Guid parkId)
    {
      if (parkId == Guid.Empty)
        throw new ArgumentNullException(nameof(parkId));

      var result = _dbContext.Parks.Find(parkId);
      result.IsDeleted = true;
    }

    public bool Save()
    {
      return _dbContext.SaveChanges() > 0;
    }
  }
}