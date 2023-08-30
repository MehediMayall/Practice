using System;
namespace MovieStar.Tests;

public class UserRepositoryTest : IDisposable
{
    private IUserRepository sut;
    private CharacterContext context;
    public UserRepositoryTest()
    {
        var contextOptions = new DbContextOptionsBuilder<CharacterContext>()
            .UseSqlServer("Server=.; Database=moviestar; User=sa; Password=e0LZ0G*#%B9)G9}P95; Trusted_Connection=false;TrustServerCertificate=true;")
            .Options;

        this.context = new CharacterContext(contextOptions);     
        this.sut = new UserRepository(this.context);
    }    

    [Fact]
    public async void GetUserListShouldReturnListOfUsers()
    {
        // Arrange
        var mockUsers = new UserMockData().GetUserList();

        // Act
        List<User> users = await sut.GetUserList();

        // Assert

        users.Should().HaveCount(c => c > 0);
        // users.Should().Equal(mockUsers.Result);
    }

    [Fact]
    public async void GetUserById_ShouldReturnAnUser()
    {
        // Arrange
        int userid = 1;

        // Act
        User user = await sut.getUserByID(userid);

        // Assert

        Assert.Equal(userid, user.Id);
        Assert.Equal("Mehedi", user.FirstName);
        // users.Should().Equal(mockUsers.Result);
    }

    public void Dispose()
    {
        GC.Collect();
    }
}