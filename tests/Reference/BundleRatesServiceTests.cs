using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class BundleRateServiceTests : CredentialManagement
{
    private const string BundleId = "1";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetBundleExchangeRatesAsync()
    {
        var result = _client.BundleRateService
            .GetBundleExchangeRatesAsync(BundleId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetBundleInternalRatesAsync()
    {
        var result = _client.BundleRateService
            .GetBundleInternalRatesAsync(BundleId).Result;
        Assert.IsNotNull(result.Body);
    }
}