using ParkAPI.DataContext;

namespace Parks.Cores.RepositoryManager
{
  public class RepositoryManager : IRepositoryManager
  {
    private ParkDbContext _dbContext;
    private IParkRepository _parkRepository;

    public RepositoryManager(ParkDbContext dbContext, IParkRepository parkRepository)
    {
      _dbContext = dbContext;
      _parkRepository = parkRepository;
    }
    public IParkRepository Park
    {
      get
      {
        if (_parkRepository == null)
          _parkRepository = new ParkRepository(_dbContext);
        
        return _parkRepository;
      }
    }
    public void Save() => _dbContext.SaveChanges();
  }
}