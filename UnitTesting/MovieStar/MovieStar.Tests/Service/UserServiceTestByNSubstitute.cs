using NSubstitute;

namespace MovieStar.Tests;

/// USING NSubstitute
public class UserServiceTestByNSubstitute
{
    private readonly IUserRepository repo;
    private readonly IUserService sut;
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
}