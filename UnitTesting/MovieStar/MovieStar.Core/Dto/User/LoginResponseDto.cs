namespace MovieStar.Core.Dto;
public class LoginResponseDto
{
    public string token { get; set; }= string.Empty;
    public UserDto user { get; set; }

}
