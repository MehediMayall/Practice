
namespace MovieStar.Tests;

public  class UserMockData
{
    public async Task<List<User>> GetUserList()
    {
        List<User> users = new List<User>();
        users.Add(new User{ Id=1, FirstName = "Mehedi", Email= "mehedi@gmail.com" });
        users.Add(new User{ Id=2, FirstName = "Rahat", Email="rahat@gmail.com" });

        return users;
    }
}