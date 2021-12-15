using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class SwapNpvRevaluationServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetSwapNPVRevaluationsAsync()
    {
        var result = _client.SwapNpvRevaluationService.GetSwapNPVRevaluationsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetSwapNPVDetailsAsync()
    {
        var result = _client.SwapNpvRevaluationService.GetSwapNPVDetailsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetSwapNPVCurrencyRevaluationsAsync()
    {
        var result = _client.SwapNpvRevaluationService.GetSwapNPVCurrencyRevaluationsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}