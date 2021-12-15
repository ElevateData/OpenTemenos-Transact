using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Reference.InterestRates;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class InterestRateServiceTests : CredentialManagement
{
    private const string RateId = "1";
    private const string Date = "20201209";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetRateTextsAsync()
    {
        var result = _client.InterestRateService
            .GetRateTextsAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetBasicInterestAsync()
    {
        var result = _client.InterestRateService.GetBasicInterestAsync(RateId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateBasicInterestAsync()
    {
        var rateId = string.Empty;
        var payload = new BasicInterest();
        var result = _client.InterestRateService
            .CreateBasicInterestAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateBasicInterestAsync()
    {
        var rateId = string.Empty;
        var payload = new BasicInterest();
        var result = _client.InterestRateService
            .UpdateBasicInterestAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetBasicInterestChangeDatesAsync()
    {
        var result = _client.InterestRateService
            .GetBasicInterestChangeDatesAsync(RateId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetBasicInterestRateChangesAsync()
    {
        var result = _client.InterestRateService.GetBasicInterestRateChangesAsync(RateId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPeriodicInterestAsync()
    {
        var result = _client.InterestRateService.GetPeriodicInterestAsync(RateId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreatePeriodicInterestAsync()
    {
        var rateId = string.Empty;
        var payload = new PeriodicInterest();
        var result = _client.InterestRateService
            .CreatePeriodicInterestAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdatePeriodicInterestAsync()
    {
        var rateId = string.Empty;
        var payload = new PeriodicInterest();
        var result = _client.InterestRateService
            .UpdatePeriodicInterestAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPeriodicRateChangesAsync()
    {
        var result = _client.InterestRateService
            .GetPeriodicRateChangesAsync(Date).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetBasicInterestNameAsync()
    {
        var result = _client.InterestRateService.GetBasicInterestNameAsync(RateId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateBasicInterestNameAsync()
    {
        var rateId = string.Empty;
        var payload = new BasicInterestName();
        var result = _client.InterestRateService
            .CreateBasicInterestNameAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateBasicInterestNameAsync()
    {
        var rateId = string.Empty;
        var payload = new BasicInterestName();
        var result = _client.InterestRateService
            .UpdateBasicInterestNameAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPeriodicRateNameAsync()
    {
        var result = _client.InterestRateService.GetPeriodicRateNameAsync(RateId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreatePeriodicRateNameAsync()
    {
        var rateId = string.Empty;
        var payload = new PeriodicRateName();
        var result = _client.InterestRateService
            .CreatePeriodicRateNameAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdatePeriodicRateNameAsync()
    {
        var rateId = string.Empty;
        var payload = new PeriodicRateName();
        var result = _client.InterestRateService
            .UpdatePeriodicRateNameAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeletePeriodicRateNameAsync()
    {
        var rateId = string.Empty;
        var payload = new PeriodicRateNameDelete();
        var result = _client.InterestRateService
            .DeletePeriodicRateNameAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}