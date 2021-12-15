using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Party.CustomerAdverts;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomerAdvertServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerAdvertsAsync()
    {
        var result = _client.CustomerAdvertService.GetCustomerAdvertsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateAdvertAsync()
    {
        var advertId = string.Empty;
        var payload = new Advert();
        var result = _client.CustomerAdvertService.UpdateAdvertAsync(advertId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateAdvertAsync()
    {
        var payload = new Advert();
        var result = _client.CustomerAdvertService.CreateAdvertAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}