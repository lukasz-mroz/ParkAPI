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
    

  }
}