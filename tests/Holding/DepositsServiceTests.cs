using System;
using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class DepositServiceTests : CredentialManagement
{
    private const string DepositId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("Obsolete")]
    [TestCategory("Obsolete")]
    [Obsolete("Flagged by Temenos")]
    public void GetDepositDetailsAsync()
    {
        var result = _client.DepositService
            .GetDepositDetailsAsync(DepositId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}