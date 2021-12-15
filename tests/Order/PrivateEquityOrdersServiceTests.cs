using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Order.PrivateEquityOrders;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class PrivateEquityOrderServiceTests : CredentialManagement
{
    private const string PrivateEquityOrderId = "1";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPrivateEquityOrderAsync()
    {
        var result = _client.PrivateEquityOrderService.GetPrivateEquityOrderAsync(PrivateEquityOrderId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreatePrivateEquityOrderAsync()
    {
        var privateEquityOrderId = string.Empty;
        var payload = new PrivateEquityOrder();
        var result = _client.PrivateEquityOrderService.CreatePrivateEquityOrderAsync(privateEquityOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdatePrivateEquityOrderAsync()
    {
        var privateEquityOrderId = string.Empty;
        var payload = new PrivateEquityOrder();
        var result = _client.PrivateEquityOrderService.UpdatePrivateEquityOrderAsync(privateEquityOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}