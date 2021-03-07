using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParkAPI.DataContext;


namespace Parks.Cores
{

  public class ParkRepository : IParkRepository
  {
    private readonly ParkDbContext _dbContext;

    public ParkRepository(ParkDbContext dbContext)
    {
      _dbContext = dbContext;
    }


    public IEnumerable<Parky> GetParks()
    {
      return 
    }

    public void AddBand()
    {
      throw new NotImplementedException();
    }
  }
}
