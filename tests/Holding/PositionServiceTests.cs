using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class PositionServiceTests : CredentialManagement
{
    private const string CurrencyId = "USD";
    private const string TransactionId = "1";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetTreasuryCashPositionAsync()
    {
        var result = _client.PositionService.GetTreasuryCashPositionAsync(CurrencyId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetTreasuryGapPositionAsync()
    {
        var result = _client.PositionService.GetTreasuryGapPositionAsync(CurrencyId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetForexRevaluationPositionsAsync()
    {
        var result = _client.PositionService.GetForexRevaluationPositionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetTreasuryTransactionDetailsAsync()
    {
        var result = _client.PositionService.GetTreasuryTransactionDetailsAsync(TransactionId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}