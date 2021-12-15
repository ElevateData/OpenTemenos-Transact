using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Microservice.GenericConfigs;

namespace OpenTemenos.Tests.Transact.Microservice;

[TestClass]
public class GenericConfigServiceTests : CredentialManagement
{
    private const string ConfigName = "1";
    private const string GroupId = "1";
    private readonly IMicroserviceClient _client = new MicroserviceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetEntitlementsByResourceAsync()
    {
        var result = _client.ConfigurationService.GetConfigByNameAsync(ConfigName, GroupId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void ModifyConfigurationAsync()
    {
        var groupId = string.Empty;
        var configName = string.Empty;
        var body = new ConfigurationInput();

        var result = _client.ConfigurationService.ModifyConfigurationAsync(groupId, configName, body)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void AddConfigurationAsync()
    {
        var groupId = string.Empty;
        var configName = string.Empty;
        var body = new Configuration();

        var result = _client.ConfigurationService.AddconfigurationAsync(groupId, configName, body)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetConfigurationsAsync()
    {
        var result = _client.ConfigurationService.GetConfigurationsAsync(GroupId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }
}