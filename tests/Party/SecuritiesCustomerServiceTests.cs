using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Party.SecuritiesCustomers;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class SecuritiesCustomerServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetSecuritiesCustomerAsync()
    {
        var result = _client.SecuritiesCustomerService.GetSecuritiesCustomerAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateSecuritiesCustomerAsync()
    {
        var customerId = string.Empty;
        var payload = new SecuritiesCustomer();
        var result = _client.SecuritiesCustomerService.CreateSecuritiesCustomerAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateSecuritiesCustomerAsync()
    {
        var customerId = string.Empty;
        var payload = new SecuritiesCustomer();
        var result = _client.SecuritiesCustomerService.UpdateSecuritiesCustomerAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}