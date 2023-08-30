using Microsoft.EntityFrameworkCore;
using MovieStar.Core.Models;

namespace MovieStar.Data;

public class UserRepository : IUserRepository
{
    private readonly CharacterContext dbContext;

    public UserRepository(CharacterContext dbContext)  
    {
        this.dbContext = dbContext;
    }

    public async Task<List<User>> GetUserList()
    {
        List<User> users = new List<User>();
        users.Add(new User{ Id=1, FirstName = "Mehedi", Email= "mehedi@gmail.com" });
        users.Add(new User{ Id=2, FirstName = "Rahat", Email="rahat@gmail.com" });

        return users;
    }

    public async Task<User> getUserByID(int id)
    {
        return await dbContext.Users.Include(c=> c.Characters).FirstOrDefaultAsync(u => u.Id == id);
        // return await dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
    }

    
    public async Task<User> getUserByEmail(string Email)
    {
        return await dbContext.Users.FirstOrDefaultAsync(u => u.Email == Email);
    }        
    
    public async Task<User> save(User user)
    {
        await dbContext.Users.AddAsync(user);
        await dbContext.SaveChangesAsync();
        return user;
    }
}
