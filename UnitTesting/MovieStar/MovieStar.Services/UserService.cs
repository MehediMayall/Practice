using System.Collections.Generic;
using MovieStar.Core.Models;
using MovieStar.Data;


namespace MovieStar.Service;

public class UserService: IUserService
{
    private readonly IUserRepository repo;
    public UserService(IUserRepository repo)
    {
        this.repo = repo;        
    }
    public async Task<List<User>> GetUserList()
    {
        return await repo.GetUserList();
    }
    public async Task<User> GetUserByID(int UserID)
    {
        return await repo.GetUserByID(UserID);
    }

}
