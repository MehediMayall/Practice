using System;
namespace MovieStar.Tests;

// Cmd + Shift + .

public class UserRepositoryTest : IDisposable
{
    private IUserRepository sut;
    private readonly CharacterContext context;
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

    [Theory]
    [InlineData(1,"mehedi@gmail.com")]
    public async void GetUserById_ShouldReturnAnUser(int UserID, string Email)
    {
        // Act
        User user = await sut.GetUserByID(UserID);

        // Assert

        Assert.Equal(UserID, user.Id);
        Assert.Equal(Email, user.Email);
        // users.Should().Equal(mockUsers.Result);
    }

    public void Dispose()
    {
        this.context.Dispose();
        GC.Collect();
    }
}