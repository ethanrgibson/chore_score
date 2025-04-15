

namespace chore_score.Repositories;

public class ChoresRepository
{

  private readonly IDbConnection _db;

  public ChoresRepository(IDbConnection db)
  {
    _db = db;
  }

  public List<Chore> GetAllChores()
  {
    string sql = "SELECT * FROM chores;";

    List<Chore> chores = _db.Query<Chore>(sql).ToList();

    return chores;
  }

  public Chore GetChoreById(int choreId)
  {
    string sql = @"SELECT id FROM chores WHERE id = @choreId;";

    Chore chore = _db.Query<Chore>(sql, new{choreId}).SingleOrDefault();

    return chore;
  }
}