using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Holding.Cards;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class CardServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetCardIssuesAsync()
    {
        var result = _client.AccountCardService.GetCardIssuesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateCardIssueAsync()
    {
        var cardIssueId = string.Empty;
        var payload = new CardIssue();
        var result = _client.AccountCardService.CreateCardIssueAsync(cardIssueId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCardIssueAsync()
    {
        var cardIssueId = string.Empty;
        var payload = new CardIssue();
        var result = _client.AccountCardService.UpdateCardIssueAsync(cardIssueId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteCardIssueAsync()
    {
        var cardIssueId = string.Empty;
        var payload = new CardIssueDelete();
        var result = _client.AccountCardService.DeleteCardIssueAsync(cardIssueId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}