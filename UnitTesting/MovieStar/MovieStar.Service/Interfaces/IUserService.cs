using System.Collections.Generic;
using MovieStar.Core;

namespace MovieStar.Service;

public interface IUserService
{
    Task<List<User>> GetUsers();
}