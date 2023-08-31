using MovieStar.Core.Dto;

namespace MovieStar.Tests;

public class UserControllerTests
{
    private readonly IUserService service;
    private readonly UserMockData mockData;
    private readonly UserController sut;

    public UserControllerTests()
    {
        this.service = Substitute.For<IUserService>();
        this.sut = new UserController(this.service);

        this.mockData = new UserMockData();

    }

    [Fact]
    public async Task GetUserList_ShouldReturnOkResult()
    {
        // Arrange
        List<User> mockUsers = await mockData.GetUserList();
        service.GetUserList().Returns(mockUsers);
        
        // Act
        var result = await sut.GetUserList();

        // Assert
        (result as OkObjectResult).StatusCode.Should().Be(200);
    }

    [Theory]
    [InlineData(1)]
    public async Task GetUser_ShouldReturnOkResultAndUser(int UserID)
    {
        // Arrange
        User mockUser = await mockData.GetUserByID(UserID);
        service.GetUserByID(UserID).Returns(mockUser);

        // Act
        //var result = (await sut.GetUserByID(UserID)).GetResponseDto();
        await sut.GetUserByID(UserID).GetResult(out var result, out ResponseDto responseDto);

        // Assert
        result.StatusCode.Should().Be(200);
        responseDto.Data.Should().NotBeNull();
    }
}