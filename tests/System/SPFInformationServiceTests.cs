using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.System;

[TestClass]
public class SPFInformationServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetSystemParametersAsync()
    {
        var result = _client.SPFInformationService.GetSystemParametersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}