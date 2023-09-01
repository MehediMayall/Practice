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
    public async Task GetUserList_ShouldReturnOkAndUsers()
    {
        // Arrange
        List<User> mockUsers = await mockData.GetUserList();
        service.GetUserList().Returns(mockUsers);

        // Act
        await sut.GetUserList().GetResult(out var result, out var responseDto);
        List<User> users = (List<User>) responseDto.Data;

        // Assert
        result.StatusCode.Should().Be(200);
        responseDto.Data.Should().NotBeNull();
        users.Should().HaveCount(x=> x > 0);
    }

    [Theory]
    [InlineData(1, "mehedi@gmail.com")]
    public async Task GetUser_ShouldReturnOkResultAndUser(int UserID, string Email)
    {
        // Arrange
        User mockUser = await mockData.GetUserByID(UserID);
        service.GetUserByID(UserID).Returns(mockUser);

        // Act
        await sut.GetUserByID(UserID).GetResult(out var result, out ResponseDto responseDto);

        User user = (User)responseDto.Data;

        // Assert
        result.StatusCode.Should().Be(200);
        responseDto.Data.Should().NotBeNull();
        user.Email.Should().Be(Email);
    }
    
    [Theory]
    [InlineData(9999)]
    public async Task GetUser_ShouldReturnNullUser(int UserID)
    {
        // Arrange
        User mockUser = await mockData.GetUserByID(UserID);
        service.GetUserByID(UserID).Returns(mockUser);

        // Act
        await sut.GetUserByID(UserID).GetResult(out var result, out ResponseDto responseDto);

        // Assert
        result.StatusCode.Should().Be(200);
        responseDto.Data.Should().BeNull();
        responseDto.Message.Should().BeEmpty();
    }


}