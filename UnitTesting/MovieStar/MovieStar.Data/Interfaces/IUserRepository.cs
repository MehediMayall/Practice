using MovieStar.Core.Models;
using System.Collections.Generic;

namespace MovieStar.Data;

public interface IUserRepository
{
    Task<List<User>> GetUserList();
    Task<User> GetUserByID(int id);
    Task<User> getUserByEmail(string Email);

    Task<User> save(User user);
}