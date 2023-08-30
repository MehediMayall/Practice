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
        List<User> userList = await this.sut.GetUserList();

        // Assert
        userRepoMock.Verify(x => x.GetUserList(), Times.Once());
        userList.Should().HaveCount(c => c >0);
        // userList.Should().Equal(mockUsers.Result);
    }
}