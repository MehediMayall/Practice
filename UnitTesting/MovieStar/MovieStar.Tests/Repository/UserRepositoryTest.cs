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

        users.Should().HaveCount(2);
        // users.Should().Equal(mockUsers.Result);
    }

    public void Dispose()
    {
        GC.Collect();
    }
}