using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Order.PositionTransferOrdersRequests;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class PositionTransferOrdersRequestServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateSecurityPositionTransferOrdersInitiationAsync()
    {
        var payload = new SecurityPositionTransferOrdersInitiation();
        var result = _client.SecurityPositionTransferService
            .CreateSecurityPositionTransferOrdersInitiationAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateSecurityPositionTransferOrdersInitiationAsync()
    {
        var positionTransferOrderId = string.Empty;
        var payload = new SecurityPositionTransferOrdersInitiation();
        var result = _client.SecurityPositionTransferService
            .UpdateSecurityPositionTransferOrdersInitiationAsync(positionTransferOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteSecurityPositionTransferOrdersInitiationAsync()
    {
        var positionTransferOrderId = string.Empty;
        var payload = new SecurityPositionTransferOrdersInitiationDelete();
        var result = _client.SecurityPositionTransferService
            .DeleteSecurityPositionTransferOrdersInitiationAsync(positionTransferOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void ApprovePositionTransferRequestAsync()
    {
        var positionTransferOrderId = string.Empty;
        var result = _client.SecurityPositionTransferService
            .ApprovePositionTransferRequestAsync(positionTransferOrderId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}