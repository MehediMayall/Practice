using MovieStar.Core;
using System.Collections.Generic;

namespace MovieStar.Data;

public interface IUserRepository
{
    Task<List<User>> GetUserList();
}