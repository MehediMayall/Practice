namespace MovieStar.Tests;

public class UserServiceTest
{
    private readonly Mock<IUserRepository> userRepoMock;
    private UserService sut;


    public UserServiceTest()
    {
        userRepoMock = new Mock<IUserRepository>();
        sut = new UserService(userRepoMock.Object);
    }

    [Fact]
    public async void GetUserListShouldReturnListOfUsers()
    {
        // Arrange
        var mockUsers = new UserMockData().GetUserList();
        userRepoMock.Setup(x => x.GetUserList()).Returns(mockUsers);

        sut = new UserService(userRepoMock.Object);

        // Act
        var userList = await this.sut.GetUserList();

        // Assert
        userList.Should().HaveCount(2);
    }
}