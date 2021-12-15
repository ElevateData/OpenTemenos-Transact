using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class NationalIdServiceTests : CredentialManagement
{
    private const string LeiId = "";
    private const string NationalIdRef = "US";
    private const string BicId = "";
    private const string ParticipantId = "1";
    private const string CountryId = "US";
    private const string CurrencyCode = "USD";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetBICFromLEIAsync()
    {
        var result = _client.NationalIdService.GetBICFromLEIAsync(LeiId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetBICsFromNationalIdAsync()
    {
        var result = _client.NationalIdService
            .GetBICsFromNationalIdAsync(NationalIdRef).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetNationalIdDetailsAsync()
    {
        var result = _client.NationalIdService
            .GetNationalIdDetailsAsync(NationalIdRef).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetNationalIdsFromBicAsync()
    {
        var result = _client.NationalIdService.GetNationalIdsFromBicAsync(BicId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void ValidateNationalIdAsync()
    {
        var result = _client.NationalIdService
            .ValidateNationalIdAsync(NationalIdRef).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetParticipantDetailsAsync()
    {
        var result = _client.NationalIdService.GetParticipantDetailsAsync(ParticipantId, CountryId, CurrencyCode)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}