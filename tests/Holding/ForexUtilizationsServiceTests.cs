using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Holding.ForexUtilizations;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class ForexUtilizationServiceTests : CredentialManagement
{
    private const string UtilizationId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetUtilizationsAsync()
    {
        var result = _client.ForexUtilizationService.GetUtilisationsAsync(UtilizationId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void AddUtilisationsAsync()
    {
        var utilisationId = string.Empty;
        var payload = new Utilisations();
        var result = _client.ForexUtilizationService
            .AddUtilisationsAsync(utilisationId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void ApproveUtilisationsAsync()
    {
        var result = _client.ForexUtilizationService.ApproveUtilisationsAsync(UtilizationId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetFxUtilisationRatesAsync()
    {
        var result = _client.ForexUtilizationService.GetFxUtilisationRatesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}