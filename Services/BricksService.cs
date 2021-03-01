using Legos.Models;
using Legos.Repository;

namespace Legos.Services
{
  public class BricksService
  {
    private readonly BricksRepository _repo;
    public BricksService(BricksRepository repo)
    {
      _repo = repo;
    }
    internal Brick Get()
    {
      return(_repo.Get());
    }
  }
}