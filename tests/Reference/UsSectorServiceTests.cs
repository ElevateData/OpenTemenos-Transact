using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsSectorServiceTests : CredentialManagement
{
    private const string CustomerType = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetUsSectorListAsync()
    {
        var result = _client.UsSectorService.GetUsSectorlistAsync(CustomerType).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}