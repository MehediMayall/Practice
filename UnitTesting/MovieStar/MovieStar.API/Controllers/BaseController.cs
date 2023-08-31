
using System.Security.Claims;

namespace MovieStar.API.Controllers;

public abstract class BaseController : Controller
{

    protected SessionUserDto GetSessionUser()
    {
        if(User.Claims==null) throw  new Exception("Invalid login signature. Please login");
        return new SessionUserDto{
            Id = int.Parse(User.Claims.FirstOrDefault(c=> c.Type == ClaimTypes.NameIdentifier).Value),
            Email = User.Claims.FirstOrDefault(c=> c.Type == ClaimTypes.Name).Value
        };
    }

    protected IActionResult getResponse(object Data)
    {
        return Ok (new ResponseDto(){ Status="OK", Message = "", Data = Data });
    }
    protected IActionResult getResponse(Exception exception)
    {
        return BadRequest( new ResponseDto(){ Status = "ERROR", Message = getErrorDetails(exception), Data = null });
    }

    private string getErrorDetails(Exception exception)
    {
        if (exception == null) return "";
        string Message = string.Empty;
        if(exception.Message!=null) Message+= exception.Message;
        if(exception.InnerException!=null && exception.InnerException.Message!=null) Message+= exception.InnerException.Message;
        return Message;
    }
}

