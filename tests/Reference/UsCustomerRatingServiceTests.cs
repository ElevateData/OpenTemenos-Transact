using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsCustomerRatingServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetUsCustomerRatingListAsync()
    {
        var result = _client.UsCustomerRatingService.GetUsCustomerRatinglistAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}