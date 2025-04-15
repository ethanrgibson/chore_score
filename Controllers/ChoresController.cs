namespace chore_score.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ChoresController : ControllerBase
{

private readonly ChoresService _choresService;

public ChoresController(ChoresService choresService){

_choresService = choresService;

}



[HttpGet]
public ActionResult<List<Chore>> GetAllChores(){ return []}


}


