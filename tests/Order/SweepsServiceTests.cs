using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Order.Sweeps;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class SweepServiceTests : CredentialManagement
{
    private const string SweepId = "1";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetSweepsAsync()
    {
        var result = _client.AccountSweepService.GetSweepsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateSweepAsync()
    {
        var payload = new Sweep();
        var result = _client.AccountSweepService.CreateSweepAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetSweepAsync()
    {
        var result = _client.AccountSweepService.GetSweepAsync(SweepId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateSweepAsync()
    {
        var sweepId = string.Empty;
        var payload = new Sweep();
        var result = _client.AccountSweepService.UpdateSweepAsync(sweepId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteSweepAsync()
    {
        var sweepId = string.Empty;
        var result = _client.AccountSweepService.DeleteSweepAsync(sweepId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void RejectSweepAsync()
    {
        var sweepId = string.Empty;
        var payload = new SweepDelete();
        var result = _client.AccountSweepService.RejectSweepAsync(sweepId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void ApproveSweepAsync()
    {
        var sweepId = string.Empty;
        var result = _client.AccountSweepService.ApproveSweepAsync(sweepId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetSweepCancellationsAsync()
    {
        var result = _client.AccountSweepService.GetSweepCancellationsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}