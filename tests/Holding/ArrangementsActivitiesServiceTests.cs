using System;
using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
[Ignore("All methods are flagged as obsolete")]
public class ArrangementsActivityServiceTests : CredentialManagement
{
    private const string ArrangementId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("Obsolete")]
    [TestCategory("Obsolete")]
    [Obsolete("Flagged by Temenos")]
    public void GetArrangementActivityLogAsync()
    {
        var result = _client.ArrangementsActivityService.GetArrangementActivityLogAsync(ArrangementId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}