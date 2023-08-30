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
        var mockUsers = new UserMockData().GetUserList();
        // this.userServiceMock.Setup(x => x.GetUserList()).Returns(mockUsers);

        this.sut = new UserController(userServiceMock.Object);
    }

    [Fact]
    public async void GetUserListShouldReturnListOfUsers()
    {
        // Act
        var userList = await this.sut.GetUserList();

        // Assert
        this.userServiceMock.Verify(x => x.GetUserList(), Times.Once());
        Assert.NotNull(userList);
        // Assert.Equal("Mehedi", userList.FirstOrDefault().Username);
    }
}