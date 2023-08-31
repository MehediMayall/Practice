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
        try
        {
            return getResponse( await this.service.GetUserList());
        }
        catch(Exception ex){ return getResponse(ex);}     
    }

    [HttpGet("{UserID}")]
    public async Task<IActionResult> GetUserByID(int UserID)
    {   
        try
        {
            return getResponse(await this.service.GetUserByID(UserID));
        }
        catch(Exception ex){ return getResponse(ex);}     
    }


}