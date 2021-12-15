using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Reference.Categories;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class CategoryServiceTests : CredentialManagement
{
    private const string CategoryId = "1000";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetCategoriesAsync()
    {
        var result = _client.CategoryService
            .GetCategoriesAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCategoryDetailsAsync()
    {
        var result = _client.CategoryService.GetCategoryDetailsAsync(CategoryId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateCategoryDetailsAsync()
    {
        var categoryId = string.Empty;
        var payload = new CategoryDetails();
        var result = _client.CategoryService
            .CreateCategoryDetailsAsync(categoryId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCategoryDetailsAsync()
    {
        var categoryId = string.Empty;
        var payload = new CategoryDetails();
        var result = _client.CategoryService
            .UpdateCategoryDetailsAsync(categoryId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}