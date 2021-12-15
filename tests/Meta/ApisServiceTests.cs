using System;
using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
public class ApiServiceTests : CredentialManagement
{
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    //TODO: compare Azure stored results against GitHub. There are already some differences.
    public void GetApiDocsAsync()
    {
        var result = _client.ApiService.GetApiDocsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    //TODO: validate versioning issues against these results
    public void GetApisAsync()
    {
        var result = _client.ApiService.GetApisAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetInternalApisAsync()
    {
        //TODO: Body is missing from response
        //var result = _client.ApiService.GetInternalApisAsync().Result;
        //Assert.IsNotNull(result.Body);
        //Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
        throw new NotImplementedException("Body is missing from response");
    }
}