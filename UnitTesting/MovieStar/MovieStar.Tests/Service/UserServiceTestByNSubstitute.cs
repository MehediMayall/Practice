using NSubstitute;

namespace MovieStar.Tests;

/// USING NSubstitute
public class UserServiceTestByNSubstitute
{
    private readonly IUserService sut;
    private readonly IUserRepository repo;
    private readonly UserMockData mockData;

    public UserServiceTestByNSubstitute()
    {
        this.repo = Substitute.For<IUserRepository>();
        this.sut = new UserService(this.repo);
        this.mockData = new UserMockData();
    }

    [Fact]
    public async Task GetUserList_ShouldReturnAtleastOneUser()
    {
        // Arrange
        var mockUsers = await mockData.GetUserList();

        this.repo.GetUserList().Returns(mockUsers);

        // Act
        List<User> users = await this.sut.GetUserList();

        // Assert
        users.Should().HaveCount(x=> x>0);
    }

    [Theory]
    [InlineData(1, "mehedi@gmail.com")]
    [InlineData(2, "rahat@gmail.com")]
    public async Task getUserByID_ShouldReturnSpecificUser(int UserId, string Email)
    {
        // Arrange
        var mockUser = await mockData.GetUserByID(UserId);
        this.repo.GetUserByID(UserId).Returns(mockUser);

        // Act
        User user = await this.sut.GetUserByID(UserId);


        // Assert
        user.Should().NotBeNull();
        Assert.Equal(Email, user.Email);
        // user.Should().Equal(Email, user.Email);
    }
}