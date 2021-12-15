using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Holding.Guarantees;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class GuaranteeServiceTests : CredentialManagement
{
    private const string ClauseId = "";
    private const string CustomerId = "100282";
    private const string GuaranteeId = "";
    private const string RequestId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetClauseAsync()
    {
        var result = _client.GuaranteeService.GetClauseAsync(ClauseId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateClauseAsync()
    {
        var clauseId = string.Empty;
        var payload = new Clause();
        var result = _client.GuaranteeService.CreateClauseAsync(clauseId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateClauseAsync()
    {
        var clauseId = string.Empty;
        var payload = new Clause();
        var result = _client.GuaranteeService.UpdateClauseAsync(clauseId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteClauseAsync()
    {
        var clauseId = string.Empty;
        var payload = new ClauseDelete();
        var result = _client.GuaranteeService.DeleteClauseAsync(clauseId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetGuaranteeIssuanceRequestsAsync()
    {
        var result = _client.GuaranteeService
            .GetGuaranteeIssuanceRequestsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateIbRequestAsync()
    {
        var payload = new IbRequest();
        var result = _client.GuaranteeService.CreateIbRequestAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetIbRequestAsync()
    {
        var result = _client.GuaranteeService.GetIbRequestAsync(RequestId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateIbRequestAsync()
    {
        var requestId = string.Empty;
        var payload = new IbRequest();
        var result = _client.GuaranteeService.UpdateIbRequestAsync(requestId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteIbRequestAsync()
    {
        var requestId = string.Empty;
        var payload = new IbRequestDelete();
        var result = _client.GuaranteeService.DeleteIbRequestAsync(requestId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void ApproveGuaranteeAsync()
    {
        var requestId = string.Empty;
        var result = _client.GuaranteeService.ApproveGuaranteeAsync(requestId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void RejectGuaranteeAsync()
    {
        var requestId = string.Empty;
        var result = _client.GuaranteeService.RejectGuaranteeAsync(requestId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetReceivedGuaranteeHistoryAsync()
    {
        var result = _client.GuaranteeService
            .GetReceivedGuaranteeHistoryAsync(GuaranteeId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetGuaranteeClausesAsync()
    {
        var result = _client.GuaranteeService
            .GetGuaranteeClausesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetReceivedGuaranteesAmendmentsAsync()
    {
        var result = _client.GuaranteeService
            .GetReceivedGuaranteesAmendmentsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetClaimInvocationHistoryAsync()
    {
        var result = _client.GuaranteeService
            .GetClaimInvocationHistoryAsync(GuaranteeId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetReceivedGuaranteeClaimsAsync()
    {
        var result = _client.GuaranteeService
            .GetReceivedGuaranteeClaimsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetGuaranteeAmendmentsAsync()
    {
        var result = _client.GuaranteeService
            .GetGuaranteeAmendmentsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetIssuedGuaranteesAsync()
    {
        var result = _client.GuaranteeService
            .GetIssuedGuaranteesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetGuaranteeLimitsAsync()
    {
        var result = _client.GuaranteeService
            .GetClaimInvocationHistoryAsync(GuaranteeId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetIssuedGuaranteeClaimsAsync()
    {
        var result = _client.GuaranteeService
            .GetIssuedGuaranteeClaimsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetGuaranteesAsync()
    {
        var result = _client.GuaranteeService
            .GetGuaranteesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateGuaranteeGenericAsync()
    {
        var payload = new GuaranteeGeneric();
        var result = _client.GuaranteeService.CreateGuaranteeGenericAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetGuaranteesOutstandingsAsync()
    {
        var result = _client.GuaranteeService.GetGuaranteesOutstandingsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetGuaranteeExpiringWithDateAsync()
    {
        var result = _client.GuaranteeService.GetGuaranteeExpiringWithDateAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetClaimOutstandingUnderGuaranteesAsync()
    {
        var result = _client.GuaranteeService.GetClaimOutstandingUnderGuaranteesAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetGuaranteesReversedAsync()
    {
        var result = _client.GuaranteeService.GetGuaranteesReversedAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetClaimsPaidUnderGuaranteeAsync()
    {
        var result = _client.GuaranteeService
            .GetClaimsPaidUnderGuaranteeAsync(GuaranteeId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetOutstandingShippingGuaranteesAsync()
    {
        var result = _client.GuaranteeService.GetOutstandingShippingGuaranteesAsync(GuaranteeId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetOutstandingReceivedGuaranteesAsync()
    {
        var result = _client.GuaranteeService.GetOutstandingReceivedGuaranteesAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateGuaranteesPerformanceBondAsync()
    {
        var payload = new GuaranteesPerformanceBond();
        var result = _client.GuaranteeService
            .CreateGuaranteesPerformanceBondAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateGuaranteesStandbyLCAsync()
    {
        var payload = new GuaranteesStandbyLC();
        var result = _client.GuaranteeService.CreateGuaranteesStandbyLCAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateShippingGuaranteeUnderLCAsync()
    {
        var payload = new ShippingGuaranteeUnderLC();
        var result = _client.GuaranteeService.CreateShippingGuaranteeUnderLCAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateShippingGuaranteeUnderCollectionAsync()
    {
        var payload = new ShippingGuaranteeUnderCollection();
        var result = _client.GuaranteeService
            .CreateShippingGuaranteeUnderCollectionAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateGuaranteesAmendmentAsync()
    {
        var guaranteeId = string.Empty;
        var payload = new GuaranteesAmendment();
        var result = _client.GuaranteeService
            .UpdateGuaranteesAmendmentAsync(guaranteeId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateGuaranteesRejectionAsync()
    {
        var guaranteeId = string.Empty;
        var payload = new GuaranteesRejection();
        var result = _client.GuaranteeService
            .UpdateGuaranteesRejectionAsync(guaranteeId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetInvocationPaidOrCancelledAsync()
    {
        var result = _client.GuaranteeService.GetInvocationPaidOrCancelledAsync(GuaranteeId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateGuarnteeBidBondAsync()
    {
        var payload = new GuarnteeBidBond();
        var result = _client.GuaranteeService.CreateGuarnteeBidBondAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}