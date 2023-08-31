using MovieStar.Core.Dto;
using System.Runtime.CompilerServices;

namespace MovieStar.Tests;

public static class OkObjectResult_Extension
{
    public static Task<IActionResult> GetResult(this Task<IActionResult> actionResult, out OkObjectResult result)
    {
        result = (OkObjectResult) actionResult.Result;
        return actionResult;
    }    
    
    public static Task<IActionResult> GetResult(this Task<IActionResult> actionResult, out OkObjectResult result, out ResponseDto ResponseDto)
    {
        result = (OkObjectResult) actionResult.Result;
        ResponseDto = (ResponseDto) result.Value;
        return actionResult;
    }


    public static OkObjectResult GetOkObject(this IActionResult result) => (OkObjectResult)result;
    public static ResponseDto GetResponseDto(this IActionResult result) => (ResponseDto) ((OkObjectResult)result).Value;
    
}
