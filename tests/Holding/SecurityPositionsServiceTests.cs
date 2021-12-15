using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class SecurityPositionServiceTests : CredentialManagement
{
    private const string InstrumentId = "1";
    private const string PortfolioId = "1";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetPortfoliosTransactionsAsync()
    {
        var result = _client.SecurityPositionService.GetPortfoliosTransactionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetSecurityInventoryPositionsAsync()
    {
        var result = _client.SecurityPositionService.GetSecurityInventoryPositionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPortfolioTransactionsAsync()
    {
        var result = _client.SecurityPositionService.GetPortfolioTransactionsAsync(PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetInstrumentPositionsAsync()
    {
        var result = _client.SecurityPositionService.GetInstrumentPositionsAsync(InstrumentId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPortfolioSecurityPositionsAsync()
    {
        var result = _client.SecurityPositionService.GetPortfolioSecurityPositionsAsync(PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetSecurityMovementsByPortfolioAsync()
    {
        var result = _client.SecurityPositionService.GetPortfoliosTransactionsAsync(PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}