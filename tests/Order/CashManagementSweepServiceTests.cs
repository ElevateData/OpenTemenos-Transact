using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Order.CashManagementSweeps;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class CashManagementSweepServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateMaintainBalanceSweepsAsync()
    {
        var accountId = string.Empty;
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.CreateMaintainBalanceSweepsAsync(accountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateMaintainBalanceSweepsAsync()
    {
        var accountId = string.Empty;
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.UpdateMaintainBalanceSweepsAsync(accountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateSurplusBalanceSweepsAsync()
    {
        var accountId = string.Empty;
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.CreateSurplusBalanceSweepsAsync(accountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateSurplusBalanceSweepsAsync()
    {
        var accountId = string.Empty;
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.UpdateSurplusBalanceSweepsAsync(accountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateZeroBalanceSweepsAsync()
    {
        var accountId = string.Empty;
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.CreateZeroBalanceSweepsAsync(accountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateZeroBalanceSweepsAsync()
    {
        var accountId = string.Empty;
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.UpdateZeroBalanceSweepsAsync(accountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateFXCurrencyMaintainBalanceSweepsAsync()
    {
        var accountId = string.Empty;
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.CreateFXCurrencyMaintainBalanceSweepsAsync(accountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateFXCurrencyMaintainBalanceSweepsAsync()
    {
        var accountId = string.Empty;
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.UpdateFXCurrencyMaintainBalanceSweepsAsync(accountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateFXSurplusBalanceSweepsAsync()
    {
        var accountId = string.Empty;
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.CreateFXSurplusBalanceSweepsAsync(accountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateFXSurplusBalanceSweepsAsync()
    {
        var accountId = string.Empty;
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.UpdateFXSurplusBalanceSweepsAsync(accountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateFXZeroBalanceSweepsAsync()
    {
        var accountId = string.Empty;
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.CreateFXZeroBalanceSweepsAsync(accountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateFXZeroBalanceSweepsAsync()
    {
        var accountId = string.Empty;
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.UpdateFXZeroBalanceSweepsAsync(accountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}