using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Party.CustomerMandates;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomerMandateServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateMandateAsync()
    {
        var customerId = string.Empty;
        var payload = new Mandate();
        var result = _client.CustomerMandateService.UpdateMandateAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateMandateParameterAsync()
    {
        var applicationId = string.Empty;
        var payload = new MandateParameter();
        var result = _client.CustomerMandateService.UpdateMandateParameterAsync(applicationId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateSignatoryGroupAsync()
    {
        var signatoryGroupId = string.Empty;
        var payload = new SignatoryGroup();
        var result = _client.CustomerMandateService.UpdateSignatoryGroupAsync(signatoryGroupId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void SimulateSignatoryMandateProcessingAsync()
    {
        var transactionSimulationId = string.Empty;
        var result = _client.CustomerMandateService.SimulateSignatoryMandateProcessingAsync(transactionSimulationId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}