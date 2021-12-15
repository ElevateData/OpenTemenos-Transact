using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Party.OnboardingCustomers;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class OnboardingCustomerServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetOnboardingCustomerAsync()
    {
        var result = _client.OnboardingCustomerService.GetOnboardingCustomerAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateOnboardingCustomerAsync()
    {
        var customerId = string.Empty;
        var payload = new OnboardingCustomer();
        var result = _client.OnboardingCustomerService.UpdateOnboardingCustomerAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateOnboardingCustomerAsync()
    {
        var payload = new OnboardingCustomer();
        var result = _client.OnboardingCustomerService.CreateOnboardingCustomerAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}