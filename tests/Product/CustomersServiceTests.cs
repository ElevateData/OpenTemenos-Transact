using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Product;

[TestClass]
public class CustomerServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private const string InterestCatalogId = "1";
    private const string PeriodicInterestId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetExternalUserAsync()
    {
        var result = _client.CustomerService.GetEligibleProductsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPeriodicInterestsAsync()
    {
        var result = _client.CustomerService.GetPeriodicInterestsAsync(PeriodicInterestId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetInterestCatalogAsync()
    {
        var result = _client.CustomerService.GetInterestCatalogAsync(InterestCatalogId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}