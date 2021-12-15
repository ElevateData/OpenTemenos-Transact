using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Reference.Currencies;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class CurrencyServiceTests : CredentialManagement
{
    private const string CurrencyId = "USD";
    private const string CurrencyMarketId = "";
    private const string NumericCurrencyCode = "";
    private const string Year = "2020";
    private const string Rank = "1";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetCurrenciesAsync()
    {
        var result = _client.CurrencyService
            .GetCurrenciesAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCurrencyInfoAsync()
    {
        var result = _client.CurrencyService.GetCurrencyInfoAsync(CurrencyId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateCurrencyInfoAsync()
    {
        var currencyId = string.Empty;
        var payload = new CurrencyInfo();
        var result = _client.CurrencyService
            .CreateCurrencyInfoAsync(currencyId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCurrencyInfoAsync()
    {
        var currencyId = string.Empty;
        var payload = new CurrencyInfo();
        var result = _client.CurrencyService
            .UpdateCurrencyInfoAsync(currencyId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteCurrencyInfoAsync()
    {
        var currencyId = string.Empty;
        var payload = new CurrencyInfoDelete();
        var result = _client.CurrencyService
            .DeleteCurrencyInfoAsync(currencyId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCurrencyMarketAsync()
    {
        var result = _client.CurrencyService.GetCurrencyMarketAsync(CurrencyMarketId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateCurrencyMarketAsync()
    {
        var currencyMarketId = string.Empty;
        var payload = new CurrencyMarket();
        var result = _client.CurrencyService
            .CreateCurrencyMarketAsync(currencyMarketId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCurrencyMarketAsync()
    {
        var currencyMarketId = string.Empty;
        var payload = new CurrencyMarket();
        var result = _client.CurrencyService
            .UpdateCurrencyMarketAsync(currencyMarketId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCurrencyFromNumericCodeAsync()
    {
        var result = _client.CurrencyService
            .GetCurrencyFromNumericCodeAsync(NumericCurrencyCode)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCurrencyModificationsAsync()
    {
        var result = _client.CurrencyService
            .GetCurrencyModificationsAsync(CurrencyId, Year).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCurrencyForRankAsync()
    {
        var result = _client.CurrencyService
            .GetCurrencyForRankAsync(Rank).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCurrencyBasicInfoAsync()
    {
        var result = _client.CurrencyService.GetCurrencyBasicInfoAsync(CurrencyId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateCurrencyBasicInfoAsync()
    {
        var currencyId = string.Empty;
        var payload = new CurrencyBasicInfo();
        var result = _client.CurrencyService
            .CreateCurrencyBasicInfoAsync(currencyId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCurrencyBasicInfoAsync()
    {
        var currencyId = string.Empty;
        var payload = new CurrencyBasicInfo();
        var result = _client.CurrencyService
            .UpdateCurrencyBasicInfoAsync(currencyId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteCurrencyBasicInfoAsync()
    {
        var currencyId = string.Empty;
        var payload = new CurrencyBasicInfoDelete();
        var result = _client.CurrencyService
            .DeleteCurrencyBasicInfoAsync(currencyId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}