using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class CreditorReferenceServiceTests : CredentialManagement
{
    private const string CreditorReference = "";
    private const string GenerateOrValidateOption = "VALIDATE";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetAccountTransfersAsync()
    {
        var result = _client.CreditorReferenceService
            .GetStructuredCreditorReferenceAsync(CreditorReference, GenerateOrValidateOption)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}