using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class DealerServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetDealersAsync()
    {
        var result = _client.DealerService.GetDealersAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}