using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.System;

[TestClass]
public class DocumentRequiredServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetRequiredDocumentsSettingsAsync()
    {
        var result = _client.DocumentRequiredService.GetRequiredDocumentsSettingsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}