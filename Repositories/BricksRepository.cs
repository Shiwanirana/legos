using System.Data;

namespace Legos.Repository
{
  public class BricksRepository
  {
    private readonly IDbConnection _db;
    public BricksRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Brick> Get()
    {
      string sql = "SELECT * FROM bricks";
      ret
    }
  }
}