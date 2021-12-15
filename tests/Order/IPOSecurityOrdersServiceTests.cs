using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Order.IPOSecurityOrders;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class IPOSecurityOrderServiceTests : CredentialManagement
{
    private const string SecurityOrderId = "1";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateSecuritiesIPOOrderAsync()
    {
        var payload = new SecuritiesIPOOrder();
        var result = _client.InitialPublicOfferingSecurityOrderService.CreateSecuritiesIPOOrderAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetSecuritiesIPOOrderAsync()
    {
        var result = _client.InitialPublicOfferingSecurityOrderService.GetSecuritiesIPOOrderAsync(SecurityOrderId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateSecuritiesIPOOrderAsync()
    {
        var securityOrderId = string.Empty;
        var payload = new SecuritiesIPOOrder();
        var result = _client.InitialPublicOfferingSecurityOrderService
            .UpdateSecuritiesIPOOrderAsync(securityOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}