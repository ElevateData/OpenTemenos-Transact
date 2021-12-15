using OpenTemenos.Transacts;
using OpenTemenos.Transacts.System.ExternalAccountings;

namespace OpenTemenos.Tests.Transact.System;

[TestClass]
public class ExternalAccountingServiceTests : CredentialManagement
{
    private const string SettingId = "1";
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetExternalAccountingSystemSettingsAsync()
    {
        var result = _client.ExternalAccountingService.GetExternalAccountingSystemSettingsAsync(SettingId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateExternalAccountingSystemSettingsAsync()
    {
        var settingId = string.Empty;
        var payload = new ExternalAccountingSystemSettings();
        var result = _client.ExternalAccountingService.CreateExternalAccountingSystemSettingsAsync(settingId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}