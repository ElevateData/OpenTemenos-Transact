using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Holding.Collaterals;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class CollateralServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateCustomerCollateralsAsync()
    {
        var payload = new CustomerCollaterals();
        var result = _client.CustomerCollateralService
            .CreateCustomerCollateralsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCustomerCollateralsAsync()
    {
        var collateralId = string.Empty;
        var payload = new CustomerCollaterals();
        var result = _client.CustomerCollateralService
            .UpdateCustomerCollateralsAsync(collateralId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerCollateralsAsync()
    {
        var result = _client.CustomerCollateralService
            .GetCustomerCollateralsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}