using System.Collections.Generic;
using MovieStar.Core;


namespace MovieStar.Service;

public class UserService: IUserService
{
    public UserService()
    {
        
    }
    public async Task<List<User>> GetUserList()
    {
        List<User> users = new List<User>();
        users.Add(new User{ Id=1, Username = "Mehedi", Email= "mehedi@gmail.com" });
        users.Add(new User{ Id=2, Username = "Rahat", Email="rahat@gmail.com" });

        return users;
    }

}
