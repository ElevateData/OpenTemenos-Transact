using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Meta.Queries;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
public class QueryServiceTests : CredentialManagement
{
    private const string QueryId = "1";
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetQueriesAsync()
    {
        var result = _client.QueryService.GetQueriesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetQueryAsync()
    {
        var result = _client.QueryService.GetQueryAsync(QueryId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateQueryAsync()
    {
        var queryId = string.Empty;
        var payload = new CreateQuery();
        var result = _client.QueryService.CreateQueryAsync(queryId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}