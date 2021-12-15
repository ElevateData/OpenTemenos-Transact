using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Reference.InterestBases;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class InterestBaseServiceTests : CredentialManagement
{
    private const string InterestBasisId = "A";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetInterestBasesAsync()
    {
        var result = _client.InterestBaseService
            .GetInterestBasesAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetInterestDayBasisDetailsAsync()
    {
        var result = _client.InterestBaseService
            .GetInterestDayBasisDetailsAsync(InterestBasisId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateInterestDayBasisAsync()
    {
        var interestBasisId = string.Empty;
        var payload = new InterestDayBasis();
        var result = _client.InterestBaseService
            .CreateInterestDayBasisAsync(interestBasisId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateInterestDayBasisAsync()
    {
        var interestBasisId = string.Empty;
        var payload = new InterestDayBasis();
        var result = _client.InterestBaseService
            .UpdateInterestDayBasisAsync(interestBasisId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteInterestDayBasisAsync()
    {
        var interestBasisId = string.Empty;
        var payload = new InterestDayBasisDelete();
        var result = _client.InterestBaseService
            .DeleteInterestDayBasisAsync(interestBasisId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}