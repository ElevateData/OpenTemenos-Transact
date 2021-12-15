using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Meta.DwExportProperties;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
public class DwExportPropertyServiceTests : CredentialManagement
{
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateDWExportPropertiesAsync()
    {
        var dataWarehouseExportId = string.Empty;
        var payload = new DWExportProperties();
        var result = _client.DwExportPropertyService.UpdateDWExportPropertiesAsync(dataWarehouseExportId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetDWExportPropertiesAsync()
    {
        var result = _client.DwExportPropertyService.GetDWExportPropertiesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}