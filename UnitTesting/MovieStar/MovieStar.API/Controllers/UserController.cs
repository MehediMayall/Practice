namespace MovieStar.API.Controllers;


[Route("api/user/")]
[ApiController]
public class UserController: BaseController
{

    private readonly IUserService service;
    public UserController(IUserService service)
    {
        this.service = service;
    }

    [HttpGet("list")]
    public async Task<IActionResult> GetUserList()
    {        
        return getResponse( await this.service.GetUserList());
    }
}