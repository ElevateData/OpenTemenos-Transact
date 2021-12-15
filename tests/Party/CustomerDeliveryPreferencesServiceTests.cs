using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Party.CustomerDeliveryPreferences;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomerDeliveryPreferenceServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerDeliveryPreferencesAsync()
    {
        var result = _client.CustomerDeliveryPreferenceService.GetCustomerDeliveryPreferencesAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateCustomerDeliveryPreferenceAsync()
    {
        var customerId = string.Empty;
        var payload = new CustomerDeliveryPreference();
        var result = _client.CustomerDeliveryPreferenceService
            .CreateCustomerDeliveryPreferenceAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCustomerDeliveryPreferenceAsync()
    {
        var customerId = string.Empty;
        var payload = new CustomerDeliveryPreference();
        var result = _client.CustomerDeliveryPreferenceService
            .UpdateCustomerDeliveryPreferenceAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteCustomerDeliveryPreferenceAsync()
    {
        var customerId = string.Empty;
        var payload = new CustomerDeliveryPreferenceDelete();
        var result = _client.CustomerDeliveryPreferenceService
            .DeleteCustomerDeliveryPreferenceAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}