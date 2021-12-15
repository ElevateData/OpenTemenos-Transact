using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class ParticipantListServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetParticipantListAsync()
    {
        var result = _client.ParticipantListService.GetParticipantListAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}