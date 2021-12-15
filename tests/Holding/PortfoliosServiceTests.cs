using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Holding.Portfolios;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class PortfolioServiceTests : CredentialManagement
{
    private const string PortfolioId = "1";
    private const string CustomerId = "100282";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdatePortfolioClosureAsync()
    {
        var portfolioId = string.Empty;
        var payload = new PortfolioClosure();
        var result = _client.PortfolioService.UpdatePortfolioClosureAsync(portfolioId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdatePortfolioDelinkAccountAsync()
    {
        var portfolioId = string.Empty;
        var payload = new PortfolioClosure();
        var result = _client.PortfolioService.UpdatePortfolioDelinkAccountAsync(portfolioId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPortfolioValuationsAsync()
    {
        var result = _client.PortfolioService.GetPortfolioValuationsAsync(PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPortfolioLTVAsync()
    {
        var result = _client.PortfolioService.GetPortfolioLTVAsync(PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetOwnBookPortfoliosAsync()
    {
        var result = _client.PortfolioService.GetOwnBookPortfoliosAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPortfolioAccountsAsync()
    {
        var result = _client.PortfolioService.GetPortfolioAccountsAsync(PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPortfoliosAsync()
    {
        var result = _client.PortfolioService.GetPortfoliosAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPortfolioAsync()
    {
        var result = _client.PortfolioService.GetPortfolioAsync(PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdatePortfolioAsync()
    {
        var portfolioId = string.Empty;
        var payload = new Portfolio();
        var result = _client.PortfolioService.UpdatePortfolioAsync(portfolioId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void ReversePortfolioAsync()
    {
        var portfolioId = string.Empty;
        var payload = new PortfolioDelete();
        var result = _client.PortfolioService.ReversePortfolioAsync(portfolioId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreatePortfolioAsync()
    {
        var payload = new Portfolio();
        var result = _client.PortfolioService.CreatePortfolioAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPortfolioOrderBlotterAsync()
    {
        var result = _client.PortfolioService.GetPortfolioOrderBlotterAsync(PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPortfolioTransactionDetailsAsync()
    {
        var result = _client.PortfolioService.GetPortfolioTransactionDetailsAsync(PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPortfolioDetailsAsync()
    {
        var result = _client.PortfolioService.GetPortfolioDetailsAsync(PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPortfolioHoldingsAsync()
    {
        var result = _client.PortfolioService.GetPortfolioHoldingsAsync(PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}