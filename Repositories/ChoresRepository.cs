


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
    string sql = @"SELECT * FROM chores WHERE id = @choreId;";

    Chore chore = _db.Query<Chore>(sql, new { choreId }).SingleOrDefault();

    return chore;
  }

  public Chore CreateChore(Chore choreData)
  {
    string sql = @"
INSERT INTO 
chores(name, description, is_complete)
VALUES (@Name, @Description, @isComplete);

SELECT * FROM chores WHERE id = LAST_INSERT_ID();";


    Chore chore = _db.Query<Chore>(sql, choreData).SingleOrDefault();

    return chore;
  }
}