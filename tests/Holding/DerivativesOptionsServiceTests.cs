using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Holding.DerivativesOptions;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class DerivativesOptionServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetSellOptionTradesAsync()
    {
        var result = _client.DerivativeInstrumentOperationService.GetSellOptionTradesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateManualAssignOptionTradesAsync()
    {
        var payload = new ManualAssignOptionTrades();
        var result = _client.DerivativeInstrumentOperationService
            .CreateManualAssignOptionTradesAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetBuyOptionTradesAsync()
    {
        var result = _client.DerivativeInstrumentOperationService.GetBuyOptionTradesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateManualExerciseOptionTradesAsync()
    {
        var payload = new ManualExerciseOptionTrades();
        var result = _client.DerivativeInstrumentOperationService
            .CreateManualExerciseOptionTradesAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetActiveOptionTradesAsync()
    {
        var result = _client.DerivativeInstrumentOperationService.GetActiveOptionTradesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateManualExpireOptionTradesAsync()
    {
        var payload = new ManualExpireOptionTrades();
        var result = _client.DerivativeInstrumentOperationService
            .CreateManualExpireOptionTradesAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}