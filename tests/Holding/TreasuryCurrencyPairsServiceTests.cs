using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class TreasuryCurrencyPairServiceTests : CredentialManagement
{
    private const string CurrencyPair = "GBPUSD";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCurrencyPairPositionsAsync()
    {
        var result = _client.TreasuryCurrencyPairService.GetCurrencyPairPositionsAsync(CurrencyPair)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCurrencyPairCalendarPositionsAsync()
    {
        var result = _client.TreasuryCurrencyPairService.GetCurrencyPairCalendarPositionsAsync(CurrencyPair)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCurrencyPairMarketRatesAsync()
    {
        var result = _client.TreasuryCurrencyPairService.GetCurrencyPairMarketRatesAsync(CurrencyPair)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetAllCurrencyPairPositionsAsync()
    {
        var result = _client.TreasuryCurrencyPairService.GetAllCurrencyPairPositionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCurrencyPairPositionDealsAsync()
    {
        var result = _client.TreasuryCurrencyPairService.GetCurrencyPairPositionDealsAsync(CurrencyPair)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetCurrencyPairsAsync()
    {
        var result = _client.TreasuryCurrencyPairService.GetCurrencyPairsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCurrencyPairAsync()
    {
        var result = _client.TreasuryCurrencyPairService.GetCurrencyPairAsync(CurrencyPair)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetFxPortfolioValuationRatesAsync()
    {
        var result = _client.TreasuryCurrencyPairService.GetFxPortfolioValuationRatesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}