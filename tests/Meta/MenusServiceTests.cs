using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Meta.Menus;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
public class MenuServiceTests : CredentialManagement
{
    private const string MenuId = "1";
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetMainMenusAsync()
    {
        var result = _client.MenuService.GetMainMenusAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetMainMenuAsync()
    {
        var result = _client.MenuService.GetMainMenuAsync(MenuId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateMainMenuAsync()
    {
        var menuId = string.Empty;
        var payload = new CreateMainMenu();
        var result = _client.MenuService.CreateMainMenuAsync(menuId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetMenusAsync()
    {
        var result = _client.MenuService.GetMenusAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetMenuAsync()
    {
        var result = _client.MenuService.GetMenuAsync(MenuId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}