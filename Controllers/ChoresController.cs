namespace chore_score.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ChoresController : ControllerBase
{

[HttpGet]
public ActionResult<List<Chore>> GetAllChores(){ return []}


}


