using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Product;

[TestClass]
public class LimitProductServiceTests : CredentialManagement
{
    private const string LimitProductId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetExternalDepositProductAsync()
    {
        var result = _client.LimitProductService.GetLimitProductAsync(LimitProductId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}