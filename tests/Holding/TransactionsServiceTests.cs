using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class TransactionServiceTests : CredentialManagement
{
    private const string TransactionId = "";
    private const string TransactionReferenceId = "FX2109691941";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetTransactionDetailsAsync()
    {
        var result = _client.TransactionService.GetTransactionDetailsAsync(TransactionId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetStatementForTransactionAsync()
    {
        var result = _client.TransactionService.GetStatementForTransactionAsync(TransactionReferenceId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetAccountTransactionsAsync()
    {
        var result = _client.TransactionService.GetAccountTransactionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}