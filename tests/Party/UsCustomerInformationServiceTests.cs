using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class UsCustomerInformationServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void GetUsCustomerInformationAsync()
    {
        var result = _client.UsCustomerInformationService.GetUsCustomerInformationAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}