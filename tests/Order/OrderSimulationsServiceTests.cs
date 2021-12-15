using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Order.OrderSimulations;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class OrderSimulationServiceTests : CredentialManagement
{
    private const string OrderSimulationId = "1";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetSecurityOrderSimulationAsync()
    {
        var result = _client.SecurityOrderSimulationService.GetSecurityOrderSimulationAsync(OrderSimulationId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateSecurityOrderSimulationAsync()
    {
        var orderSimulationId = string.Empty;
        var payload = new SecurityOrderSimulation();
        var result = _client.SecurityOrderSimulationService
            .CreateSecurityOrderSimulationAsync(orderSimulationId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}