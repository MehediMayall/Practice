namespace MovieStar.Tests;

public class UserControllerTest
{
    private Mock<IUserService> userServiceMock;
    private readonly UserController sut;

    public UserControllerTest()
    {
        this.userServiceMock = new Mock<IUserService>();
        this.sut = new UserController(userServiceMock.Object);
    }

    [Fact]
    public void GetUserListShouldReturnListOfUsers()
    {
        // Act
        var userList = this.sut.GetUserList();

        // Assert
        Assert.NotNull(userList);
    }
}