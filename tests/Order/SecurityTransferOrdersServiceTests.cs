using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Order.SecurityTransferOrders;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class SecurityTransferOrderServiceTests : CredentialManagement
{
    private const string SecurityTransferOrderId = "1";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetInboundSecurityTransferOrdersAsync()
    {
        var result = _client.SecurityTransferService.GetInboundSecurityTransferOrdersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetOutboundSecurityTransferOrdersAsync()
    {
        var result = _client.SecurityTransferService.GetOutboundSecurityTransferOrdersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateSecurityTransferOrderAsync()
    {
        var payload = new SecurityTransferOrder();
        var result = _client.SecurityTransferService.CreateSecurityTransferOrderAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetSecurityTransferOrdersAsync()
    {
        var result = _client.SecurityTransferService.GetSecurityTransferOrdersAsync(SecurityTransferOrderId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateSecurityTransferOrderAsync()
    {
        var securityTransferOrderId = string.Empty;
        var payload = new SecurityTransferOrder();
        var result = _client.SecurityTransferService.UpdateSecurityTransferOrderAsync(securityTransferOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateSecurityTransferDraftOrderAsync()
    {
        var payload = new SecurityTransferOrder();
        var result = _client.SecurityTransferService.CreateSecurityTransferDraftOrderAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateSecurityTransferRequestAsync()
    {
        var payload = new SecurityTransferRequest();
        var result = _client.SecurityTransferService.CreateSecurityTransferRequestAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}