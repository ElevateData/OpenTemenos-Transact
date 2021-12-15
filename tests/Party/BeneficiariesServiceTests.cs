using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Party.Beneficiaries;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class BeneficiaryServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateBeneficiaryAsync()
    {
        var beneficiaryId = string.Empty;
        var payload = new Beneficiary();
        var result = _client.BeneficiaryService.UpdateBeneficiaryAsync(beneficiaryId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteBeneficiaryAsync()
    {
        var beneficiaryId = string.Empty;
        var payload = new BeneficiaryDelete();
        var result = _client.BeneficiaryService.DeleteBeneficiaryAsync(beneficiaryId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateBeneficiaryAsync()
    {
        var payload = new Beneficiary();
        var result = _client.BeneficiaryService.CreateBeneficiaryAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void ApproveBeneficiaryAsync()
    {
        var beneficiaryId = string.Empty;
        var result = _client.BeneficiaryService.ApproveBeneficiaryAsync(beneficiaryId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void RejectBeneficiaryAsync()
    {
        var beneficiaryId = string.Empty;
        var payload = new BeneficiaryDelete();
        var result = _client.BeneficiaryService.RejectBeneficiaryAsync(beneficiaryId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerBeneficiaryAsync()
    {
        var result = _client.BeneficiaryService.GetCustomerBeneficiaryAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerBeneficiariesAsync()
    {
        var result = _client.BeneficiaryService.GetCustomerBeneficiariesAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}