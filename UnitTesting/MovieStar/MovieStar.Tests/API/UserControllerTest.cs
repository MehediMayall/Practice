using System.Linq;
using System.Collections.Generic;

namespace MovieStar.Tests;

public class UserControllerTest
{
    private Mock<IUserService> userServiceMock;
    private readonly UserController sut;
    public ITestOutputHelper TestOutput { get; }

    public UserControllerTest(ITestOutputHelper testOutput)
    {
        this.TestOutput = testOutput;
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


        // TestOutput.WriteLine(userList.GetType().ToString());

        // Assert
        this.userServiceMock.Verify(x => x.GetUserList(), Times.Once());
        Assert.NotNull(userList);

        userList.GetType().Should().Be(typeof(OkObjectResult));
        (userList as OkObjectResult).StatusCode.Should().Be(200);
        // Assert.Equal("Mehedi", userList.FirstOrDefault().Username);
    }
}