using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class UsDashboardServiceTests : CredentialManagement
{
    private const string AccountId = "100005";
    private const string CustomerId = "100282";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetUsCustomerHoldingsAsync()
    {
        var result = _client.UsModelBank.HoldingSummaryService.GetUsCustomerHoldingsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetUsDepositsDashboardAsync()
    {
        var result = _client.UsModelBank.HoldingSummaryService.GetUsDepositsDashboardAsync(AccountId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetUsAccountsHoldingsAsync()
    {
        var result = _client.UsModelBank.HoldingSummaryService.GetUsAccountsHoldingsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetUsAccountsDashboardAsync()
    {
        var result = _client.UsModelBank.HoldingSummaryService.GetUsAccountsDashboardAsync(AccountId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}