using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Order.ForexCustomerOrders;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class ForexCustomerOrderServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private const string LimitOrderId = "1";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerForexLimitOrdersAsync()
    {
        var result = _client.TreasuryForexOrderService.GetCustomerForexLimitOrdersAsync(LimitOrderId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateForexLimitOrderAsync()
    {
        var limitOrderId = string.Empty;
        var payload = new ForexLimitOrder();
        var result = _client.TreasuryForexOrderService.UpdateForexLimitOrderAsync(limitOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateForexLimitOrderAsync()
    {
        var payload = new ForexLimitOrder1();
        var result = _client.TreasuryForexOrderService.CreateForexLimitOrderAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerForexDealsAsync()
    {
        var result = _client.TreasuryForexOrderService.GetCustomerForexDealsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetForexOrdersAsync()
    {
        var result = _client.TreasuryForexOrderService.GetForexOrdersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateForexOrderAsync()
    {
        var payload = new ForexOrder();
        var result = _client.TreasuryForexOrderService.CreateForexOrderAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetOutstandingForexOrdersAsync()
    {
        var result = _client.TreasuryForexOrderService.GetOutstandingForexOrdersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}