using ChoreScore.Services;
using Microsoft.AspNetCore.Mvc.Infrastructure;

[ApiController]
[Route("api/chores")]
public class ChoresController : ControllerBase
{

    private readonly ChoresService _choresService;

    public ChoresController(ChoresService cs)
    {
        _choresService = cs;
    }

    // Test first, code small test small :D
    [HttpGet("test")]

    public string GetTest()
    {
        return "hey it worked";
    }

    [HttpPost]
    public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
    {
        try
        {
            Chore chore = _choresService.CreateChore(choreData);
            return Ok(chore);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }

    [HttpGet]
    public ActionResult<List<Chore>> GetChores()
    {
        try
        {
            List<Chore> chores = _choresService.GetChores();
            return Ok(chores);

        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }
    [HttpGet("{choreId}")]
    public ActionResult<Chore> GetChoreById(int choreId)
    {
        try
        {
            Chore chore = _choresService.GetChoreById(choreId);
            return Ok(chore);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }

    [HttpDelete("{choreId}")]
    public ActionResult<string> RemoveChore(int choreId)
    {
        try
        {
            string message = _choresService.RemoveChore(choreId);
            return Ok(message);
        }
        catch (Exception error)

        {
            return BadRequest(error.Message);
        }
    }


}