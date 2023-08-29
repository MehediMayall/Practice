using Microsoft.AspNetCore.Mvc;

namespace MovieStar.API.Controllers;


[Route("api/user/")]
[ApiController]
public class UserController: ControllerBase
{

    [HttpGet("list")]
    public async Task<ActionResult<string>> GetUserList()
    {
        return Ok("Hello Mars");
    }
}