using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Party.CustomersMiFIDs;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomersMiFIDServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetMiFIDClientInformationAsync()
    {
        var result = _client.CustomersMiFIDService.GetMiFIDClientInformationAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateMiFIDClientInformationAsync()
    {
        var customerId = string.Empty;
        var payload = new MiFIDClientInformation();
        var result = _client.CustomersMiFIDService.CreateMiFIDClientInformationAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateMiFIDClientInformationAsync()
    {
        var customerId = string.Empty;
        var payload = new MiFIDClientInformation();
        var result = _client.CustomersMiFIDService.UpdateMiFIDClientInformationAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}