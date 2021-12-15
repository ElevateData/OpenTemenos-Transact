using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Meta.Screens;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
public class ScreenServiceTests : CredentialManagement
{
    private const string ScreenId = "1";
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetScreensAsync()
    {
        var result = _client.ScreenService.GetScreensAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetScreenAsync()
    {
        var result = _client.ScreenService.GetScreenAsync(ScreenId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateScreenAsync()
    {
        var screenId = string.Empty;
        var payload = new CreateScreen();
        var result = _client.ScreenService.CreateScreenAsync(screenId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}