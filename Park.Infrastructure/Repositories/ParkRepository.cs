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


    public IEnumerable<Parky> GetBand()
    {
      var dbContextPark =  _dbContext.Parks.Where(a => a.Name == "Alabama");

      return dbContextPark;
    }

    public void AddBand()
    {
      throw new NotImplementedException();
    }
  }
}
