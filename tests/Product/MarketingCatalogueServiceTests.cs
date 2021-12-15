using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Product;

[TestClass]
public class MarketingCatalogueServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetProductMarketingCatalogueAsync()
    {
        var result = _client.MarketingCatalogueService.GetProductMarketingCatalogueAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetSavingsAccountCatalogAsync()
    {
        var result = _client.MarketingCatalogueService.GetSavingsAccountCatalogAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetCurrentAccountCatalogAsync()
    {
        var result = _client.MarketingCatalogueService.GetCurrentAccountCatalogAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetTermDepositsCatalogAsync()
    {
        var result = _client.MarketingCatalogueService.GetTermDepositsCatalogAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetShortTermFinanceCatalogAsync()
    {
        var result = _client.MarketingCatalogueService.GetShortTermFinanceCatalogAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetPersonalLoanCatalogAsync()
    {
        var result = _client.MarketingCatalogueService.GetPersonalLoanCatalogAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetMortgageCatalogAsync()
    {
        var result = _client.MarketingCatalogueService.GetMortgageCatalogAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetHomePurchaseCatalogAsync()
    {
        var result = _client.MarketingCatalogueService.GetHomePurchaseCatalogAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}