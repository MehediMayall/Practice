using Microsoft.AspNetCore.Mvc;
using MovieStar.Service;
using MovieStar.Core;


namespace MovieStar.API.Controllers;


[Route("api/user/")]
[ApiController]
public class UserController: ControllerBase
{

    private readonly IUserService service;
    public UserController(IUserService service)
    {
        this.service = service;
    }

    [HttpGet("list")]
    public async Task<IActionResult> GetUserList()
    {        
        return Ok( await this.service.GetUserList());
    }
}