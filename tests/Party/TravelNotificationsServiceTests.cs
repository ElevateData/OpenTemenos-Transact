using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Party.TravelNotifications;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class TravelNotificationServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateTravelNotificationAsync()
    {
        var travelNotificationId = string.Empty;
        var payload = new TravelNotification();
        var result = _client.TravelNotificationService.UpdateTravelNotificationAsync(travelNotificationId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteTravelNotificationAsync()
    {
        var travelNotificationId = string.Empty;
        var payload = new TravelNotificationDelete();
        var result = _client.TravelNotificationService.DeleteTravelNotificationAsync(travelNotificationId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateTravelNotificationAsync()
    {
        var payload = new TravelNotification();
        var result = _client.TravelNotificationService.CreateTravelNotificationAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void GetCustomerTravelNotificationsAsync()
    {
        var result = _client.TravelNotificationService.GetCustomerTravelNotificationsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}