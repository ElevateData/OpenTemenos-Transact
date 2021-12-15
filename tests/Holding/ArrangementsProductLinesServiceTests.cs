using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class ArrangementsProductLineServiceTests : CredentialManagement
{
    private const string ProductLine = "3";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetUnapprovedArrangementsDepositsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetUnapprovedArrangementsDepositsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetUnapprovedArrangementsLoansAsync()
    {
        var result = _client.ArrangementForProductLineService.GetUnapprovedArrangementsLoansAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetUnapprovedArrangementsAccountsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetUnapprovedArrangementsAccountsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetAAPendingArrangementAccountsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetAAPendingArrangementAccountsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetAAPendingArrangementDepositsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetAAPendingArrangementDepositsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetAAPendingArrangementLoansAsync()
    {
        var result = _client.ArrangementForProductLineService.GetAAPendingArrangementLoansAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetApprovedAccountsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetApprovedAccountsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetApprovedDepositsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetApprovedDepositsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetApprovedLoansAsync()
    {
        var result = _client.ArrangementForProductLineService.GetApprovedLoansAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetClosedMaturedAccountsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetClosedMaturedAccountsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetClosedMaturedDepositsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetClosedMaturedDepositsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetClosedMaturedLendingAsync()
    {
        var result = _client.ArrangementForProductLineService.GetClosedMaturedLendingAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetSimulatedAccountsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetSimulatedAccountsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetSimulatedDepositsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetSimulatedDepositsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetSimulatedLendingAsync()
    {
        var result = _client.ArrangementForProductLineService.GetSimulatedLendingAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}