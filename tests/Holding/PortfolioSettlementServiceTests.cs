using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Holding.PortfolioSettlements;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class PortfolioSettlementServiceTests : CredentialManagement
{
    private const string PortfolioId = "1";
    private const string SecuritySettlementsId = "1";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetOverdueSettlementsByPortfolioAsync()
    {
        var result = _client.SecuritySettlementService.GetOverdueSettlementsByPortfolioAsync(PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetSecuritySettlementsAsync()
    {
        var result = _client.SecuritySettlementService.GetSecuritySettlementsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetFullSettlementsAsync()
    {
        var result = _client.SecuritySettlementService.GetFullSettlementsAsync(SecuritySettlementsId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateFullSettlementsAsync()
    {
        var securitySettlementsId = string.Empty;
        var payload = new FullSettlements();
        var result = _client.SecuritySettlementService.UpdateFullSettlementsAsync(securitySettlementsId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPartialSettlementsAsync()
    {
        var result = _client.SecuritySettlementService.GetPartialSettlementsAsync(SecuritySettlementsId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdatePartialSettlementsAsync()
    {
        var securitySettlementsId = string.Empty;
        var payload = new PartialSettlements();
        var result = _client.SecuritySettlementService.UpdatePartialSettlementsAsync(securitySettlementsId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}