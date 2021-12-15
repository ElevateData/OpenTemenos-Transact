using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Microservice.Traceabilities;

namespace OpenTemenos.Tests.Transact.Microservice;

[TestClass]
public class TraceabilityServiceTests : CredentialManagement
{
    private const string Category = "Test";
    private const string TraceType = "Test";
    private readonly IMicroserviceClient _client = new MicroserviceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetSequenceAsync()
    {
        var result = _client.TraceabilityService.GetTraceLogAsync(Category, TraceType)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetSignatureAsync()
    {
        var message = string.Empty;
        var mode = Mode.S;
        var result = _client.TraceabilityService.GetSignatureAsync(message, mode)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetEvidenceAsync()
    {
        var result = _client.TraceabilityService.GetEvidenceAsync(Category, TraceType)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateTraceLogsAsync()
    {
        var traceLogId = string.Empty;
        var traceType = string.Empty;
        var result = _client.TraceabilityService.CreateTraceLogsAsync(traceLogId, traceType)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }
}