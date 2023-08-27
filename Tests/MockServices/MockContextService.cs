
public class MockContextService : IContextService
{
    public Mock<IContextService> Mock { get; } = new Mock<IContextService>();

    public MockContextService()
    {
        // Setup default mock behaviors here.
        Mock.Setup(service => service.GetData(It.IsAny<int>()))
            .Returns<int>(id => $"Mocked Data for ID: {id}");
    }

    public string GetData(int id)
    {
        return Mock.Object.GetData(id);
    }
}
