
public class MockContextServiceTests
{
    private readonly MockContextService _mockContextService;

    public MockContextServiceTests()
    {
        _mockContextService = new MockContextService();
    }

    [Fact]
    public void GetData_ReturnsCorrectValue()
    {
        // Arrange
        int testId = 123;

        // Act
        var result = _mockContextService.GetUserContextData(testId);

        // Assert
        Assert.Equal($"Mocked Data for ID: {testId}", result);
    }
}