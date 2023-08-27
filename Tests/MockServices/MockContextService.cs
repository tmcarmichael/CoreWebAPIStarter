
public class MockContextService : IContextService
{
    public Mock<IContextService> Mock { get; } = new Mock<IContextService>();

    public MockContextService()
    {
        Mock.Setup(service => service.GetUserContextData(It.IsAny<int>()))
            .Returns<int>(id => $"Mocked Data for ID: {id}");
    }

    public string GetUserContextData(int id)
    {
        return Mock.Object.GetUserContextData(id);
    }
}
