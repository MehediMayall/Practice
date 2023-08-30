using System.Collections.Generic;
using MovieStar.Core.Models;

namespace MovieStar.Service;

public interface IUserService
{
    Task<List<User>> GetUserList();
}