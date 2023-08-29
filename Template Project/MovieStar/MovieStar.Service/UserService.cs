using System.Collections.Generic;
using MovieStar.Core;


namespace MovieStar.Service;

public class UserService: IUserService
{
    public UserService()
    {
        
    }
    public async Task<List<User>> GetUsers()
    {
        return new List<User>();
    }

}
