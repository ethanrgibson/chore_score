namespace chore_score.Repositories;

public class ChoresRepository
{

  private readonly IDbConnection _db;

  public ChoresRepository(IDbConnection db)
  {
    _db = db;
  }
}