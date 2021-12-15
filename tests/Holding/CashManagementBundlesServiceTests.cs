using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class CashManagementBundleServiceTests : CredentialManagement
{
    private const string AccountId = "100005";
    private const string BundleId = "";
    private const string CurrencyId = "USD";
    private const string CustomerId = "100282";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCashPoolExceptionLogAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetCashPoolExceptionLogAsync(BundleId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetBundleAccountsAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetBundleAccountsAsync(BundleId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetBundleHistoryDetailsAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetBundleHistoryDetailsAsync(BundleId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetBundleArrangementsAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetBundleArrangementsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetBundleBalancesAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetBundleBalancesAsync(BundleId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerBundleAccountsAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetCustomerBundleAccountsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetDraftArrangementsAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetDraftArrangementsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetDraftBundleListAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetDraftBundleListAsync(BundleId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetNonBalanceNettingAccountsAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetNonBalanceNettingAccountsAsync(BundleId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetBundleAccountBalancesAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetBundleAccountBalancesAsync(AccountId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetBalanceInPreferredCurrencyAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetBalanceInPreferredCurrencyAsync(BundleId,
                CurrencyId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}