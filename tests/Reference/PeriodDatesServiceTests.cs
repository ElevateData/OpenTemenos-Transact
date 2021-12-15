using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class PeriodDateServiceTests : CredentialManagement
{
    private const string CurrencyOrPair = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPeriodDatesAsync()
    {
        var result = _client.PeriodDateService
            .GetPeriodDatesAsync(CurrencyOrPair).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}