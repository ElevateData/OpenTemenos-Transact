using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Product.ExternalProducts;

namespace OpenTemenos.Tests.Transact.Product;

[TestClass]
public class ExternalProductServiceTests : CredentialManagement
{
    private const string ProductId = "CURRENT.ACCOUNT";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetExternalUserAsync()
    {
        var result = _client.ExternalProductService.GetExternalMortgageProductAsync(ProductId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateExternalMortgageProductAsync()
    {
        var productId = string.Empty;
        var payload = new ExternalMortgageProduct();
        var result = _client.ExternalProductService.CreateExternalMortgageProductAsync(productId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateExternalMortgageProductAsync()
    {
        var productId = string.Empty;
        var payload = new ExternalMortgageProduct();
        var result = _client.ExternalProductService.UpdateExternalMortgageProductAsync(productId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetExternalCurrentAccountProductAsync()
    {
        var result = _client.ExternalProductService.GetExternalCurrentAccountProductAsync(ProductId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateExternalCurrentAccountProductAsync()
    {
        var productId = string.Empty;
        var payload = new ExternalCurrentAccountProduct();
        var result = _client.ExternalProductService.CreateExternalCurrentAccountProductAsync(productId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateExternalCurrentAccountProductAsync()
    {
        var productId = string.Empty;
        var payload = new ExternalCurrentAccountProduct();
        var result = _client.ExternalProductService.UpdateExternalCurrentAccountProductAsync(productId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetExternalSavingsAccountProductAsync()
    {
        var result = _client.ExternalProductService.GetExternalSavingsAccountProductAsync(ProductId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateExternalSavingsAccountProductAsync()
    {
        var productId = string.Empty;
        var payload = new ExternalSavingsAccountProduct();
        var result = _client.ExternalProductService.CreateExternalSavingsAccountProductAsync(productId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateExternalSavingsAccountProductAsync()
    {
        var productId = string.Empty;
        var payload = new ExternalSavingsAccountProduct();
        var result = _client.ExternalProductService.UpdateExternalSavingsAccountProductAsync(productId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateExternalDepositProductAsync()
    {
        var productId = string.Empty;
        var payload = new ExternalDepositProduct();
        var result = _client.ExternalProductService.CreateExternalDepositProductAsync(productId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateExternalDepositProductAsync()
    {
        var productId = string.Empty;
        var payload = new ExternalDepositProduct();
        var result = _client.ExternalProductService.UpdateExternalDepositProductAsync(productId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetExternalDepositProductAsync()
    {
        var result = _client.ExternalProductService.GetExternalDepositProductAsync(ProductId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}