using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
public class TableServiceTests : CredentialManagement
{
    private const string TableId = "1";
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetFieldNamesAsync()
    {
        var result = _client.TableService.GetTablesAsync(TableId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetTablesAsync()
    {
        var result = _client.TableService.GetTablesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetTableScreensAsync()
    {
        var result = _client.TableService.GetTableScreensAsync(TableId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}