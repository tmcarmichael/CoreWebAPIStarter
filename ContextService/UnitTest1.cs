using Moq;
using ContextService.Interfaces;

public class MyTests
{
    [Fact]
    public void GetData_ReturnsCorrectValue()
    {
        // Arrange
        var mockService = new Mock<IContextService>();
        mockService.Setup(s => s.GetUserInfo(It.IsAny<string>())).Returns("Mocked Data");

        var service = mockService.Object;

        // Act
        var result = service.GetUserInfo("user context");

        // Assert
        Assert.Equal("Mocked Data", result);
    }
}