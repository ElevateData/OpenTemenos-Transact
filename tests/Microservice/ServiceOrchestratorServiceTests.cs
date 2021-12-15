using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Microservice.ServiceOrchestrators;

namespace OpenTemenos.Tests.Transact.Microservice;

[TestClass]
public class ServiceOrchestratorServiceTests : CredentialManagement
{
    private const string SequenceId = "1";
    private readonly IMicroserviceClient _client = new MicroserviceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateSequenceAsync()
    {
        var body = new Sequence();
        var result = _client.ServiceOrchestratorService.CreateSequenceAsync(body)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetSequenceAsync()
    {
        var result = _client.ServiceOrchestratorService.GetSequenceAsync()
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetSequenceByIdAsync()
    {
        var result = _client.ServiceOrchestratorService.GetSequenceByIdAsync(SequenceId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void CancelSequenceAsync()
    {
        var result = _client.ServiceOrchestratorService.CancelSequenceAsync(SequenceId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }
}