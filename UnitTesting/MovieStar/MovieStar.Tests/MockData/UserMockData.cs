using System.Linq;

namespace MovieStar.Tests;

public  class UserMockData
{
    private readonly List<User> users;
    public UserMockData()
    {
        this.users = new List<User>();
        users.Add(new User{ Id=1, FirstName = "Mehedi", Email= "mehedi@gmail.com" });
        users.Add(new User{ Id=2, FirstName = "Rahat", Email="rahat@gmail.com" });

    }
    public async Task<List<User>> GetUserList() => users;
    public async Task<User> GetUserByID(int Id) => users.Where(e=> e.Id == Id).FirstOrDefault();
    
}