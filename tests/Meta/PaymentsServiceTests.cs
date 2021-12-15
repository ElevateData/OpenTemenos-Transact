using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
public class PaymentServiceTests : CredentialManagement
{
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetQueryFiltersAsync()
    {
        var result = _client.PaymentService.GetQueryFiltersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}