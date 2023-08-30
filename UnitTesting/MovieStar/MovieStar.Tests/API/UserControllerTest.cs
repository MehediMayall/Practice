using System.Linq;
using System.Collections.Generic;

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
    public async void GetUserListShouldReturnListOfUsers()
    {
        // Act
        var userList = await this.sut.GetUserList();
        List<User> users = (OkObjectResult) userList.Result;

        // Assert
        Assert.NotNull(userList);
        // Assert.Equal("Mehedi", userList.FirstOrDefault().Username);
    }
}