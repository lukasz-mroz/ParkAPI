namespace Parks.Cores.RepositoryManager
{
  public interface IRepositoryManager
  {
    IParkRepository Park { get; }
    void Save();
  }
}