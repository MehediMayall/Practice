namespace MovieStar.Tests;

public class UserRepositoryTest
{
    private IUserRepository sut;
    public UserRepositoryTest()
    {
        this.sut = new UserRepository();
    }    

    [Fact]
    public async void GetUserListShouldReturnListOfUsers()
    {
        // Arrange
        var mockUsers = new UserMockData().GetUserList();

        // Act
        List<User> users = await sut.GetUserList();

        // Assert

        users.Should().HaveCount(2);
        // users.Should().Equal(mockUsers.Result);
    }
}