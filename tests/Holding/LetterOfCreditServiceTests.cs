using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Holding.LetterOfCredits;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class LetterOfCreditServiceTests : CredentialManagement
{
    private const string ClausesId = "1";
    private const string CustomerId = "100282";
    private const string DocumentId = "1";
    private const string DrawingId = "1";
    private const string LcAmendmentId = "1";
    private const string LetterOfCreditId = "TF2107816028";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateDrawingAsync()
    {
        var drawingId = string.Empty;
        var payload = new Drawing();
        var result = _client.LetterOfCreditService.CreateDrawingAsync(drawingId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetDrawingAsync()
    {
        var result = _client.LetterOfCreditService.GetDrawingAsync(DrawingId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateDrawingAsync()
    {
        var drawingId = string.Empty;
        var payload = new Drawing();
        var result = _client.LetterOfCreditService.UpdateDrawingAsync(drawingId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteDrawingAsync()
    {
        var drawingId = string.Empty;
        var payload = new DrawingDelete();
        var result = _client.LetterOfCreditService.DeleteDrawingAsync(drawingId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void ApproveDrawingAsync()
    {
        var drawingId = string.Empty;
        var result = _client.LetterOfCreditService.ApproveDrawingAsync(drawingId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetLcDocumentAsync()
    {
        var result = _client.LetterOfCreditService.GetLcDocumentAsync(DocumentId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateLcDocumentAsync()
    {
        var documentId = string.Empty;
        var payload = new LcDocument();
        var result = _client.LetterOfCreditService.CreateLcDocumentAsync(documentId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateLcDocumentAsync()
    {
        var documentId = string.Empty;
        var payload = new LcDocument();
        var result = _client.LetterOfCreditService.UpdateLcDocumentAsync(documentId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteLcDocumentAsync()
    {
        var documentId = string.Empty;
        var payload = new LcDocumentDelete();
        var result = _client.LetterOfCreditService.DeleteLcDocumentAsync(documentId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateLcAmendmentAsync()
    {
        var letterOfCreditId = string.Empty;
        var payload = new LcAmendment();
        var result = _client.LetterOfCreditService.CreateLcAmendmentAsync(letterOfCreditId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetLCAmendmentsAsync()
    {
        var result = _client.LetterOfCreditService.GetLCAmendmentsAsync(LetterOfCreditId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateLcAmendmentAsync()
    {
        var letterOfCreditId = string.Empty;
        var payload = new LcAmendment();
        var result = _client.LetterOfCreditService.UpdateLcAmendmentAsync(letterOfCreditId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteLcAmendmentAsync()
    {
        var letterOfCreditId = string.Empty;
        var payload = new LcAmendmentDelete();
        var result = _client.LetterOfCreditService.DeleteLcAmendmentAsync(letterOfCreditId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void ApproveLcAmendmentAsync()
    {
        var letterOfCreditId = string.Empty;
        var result = _client.LetterOfCreditService.ApproveLcAmendmentAsync(letterOfCreditId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetLcClauseAsync()
    {
        var result = _client.LetterOfCreditService.GetLcClauseAsync(ClausesId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateLcClauseAsync()
    {
        var clausesId = string.Empty;
        var payload = new LcClause();
        var result = _client.LetterOfCreditService.CreateLcClauseAsync(clausesId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateLcClauseAsync()
    {
        var clausesId = string.Empty;
        var payload = new LcClause();
        var result = _client.LetterOfCreditService.UpdateLcClauseAsync(clausesId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteLcClauseAsync()
    {
        var clausesId = string.Empty;
        var payload = new LcClauseDelete();
        var result = _client.LetterOfCreditService.DeleteLcClauseAsync(clausesId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetDrawingsAsync()
    {
        var result = _client.LetterOfCreditService.GetDrawingsAsync(LetterOfCreditId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetLCDocumentsAsync()
    {
        var result = _client.LetterOfCreditService.GetLCDocumentsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetLCClausesAsync()
    {
        var result = _client.LetterOfCreditService.GetLCClausesAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetIncoTermsAsync()
    {
        var result = _client.LetterOfCreditService.GetIncoTermsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetLetterOfCreditsAsync()
    {
        var result = _client.LetterOfCreditService.GetLetterOfCreditsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetExportDrawingsAsync()
    {
        var result = _client.LetterOfCreditService.GetExportDrawingsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetExportLCAmendmentsAsync()
    {
        var result = _client.LetterOfCreditService.GetExportLCAmendmentsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetExportLcAsync()
    {
        var result = _client.LetterOfCreditService.GetExportLcAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetImportDrawingsAsync()
    {
        var result = _client.LetterOfCreditService.GetImportDrawingsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetImportLCAmendmentsAsync()
    {
        var result = _client.LetterOfCreditService.GetImportLCAmendmentsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetImportLcAsync()
    {
        var result = _client.LetterOfCreditService.GetImportLcAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetOutwardCollectionDocumentsAsync()
    {
        var result = _client.LetterOfCreditService.GetOutwardCollectionDocumentsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetInwardCollectionsAmendmentsAsync()
    {
        var result = _client.LetterOfCreditService.GetInwardCollectionsAmendmentsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetInwardCollectionsAsync()
    {
        var result = _client.LetterOfCreditService.GetInwardCollectionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetLcTenorsAsync()
    {
        var result = _client.LetterOfCreditService.GetLcTenorsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetOutwardCollectionAmendmentsAsync()
    {
        var result = _client.LetterOfCreditService.GetOutwardCollectionAmdendmentsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetOutwardCollectionsAsync()
    {
        var result = _client.LetterOfCreditService.GetOutwardCollectionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetLcLimitsAsync()
    {
        var result = _client.LetterOfCreditService.GetLcLimitsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void RejectDrawingAsync()
    {
        var drawingId = string.Empty;
        var payload = new DrawingDelete();
        var result = _client.LetterOfCreditService.RejectDrawingAsync(drawingId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void RejectLcAmendmentAsync()
    {
        var letterOfCreditId = string.Empty;
        var payload = new LcAmendmentDelete();
        var result = _client.LetterOfCreditService.RejectLcAmendmentAsync(letterOfCreditId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetApprovedOutwardCollectionsAsync()
    {
        var result = _client.LetterOfCreditService.GetApprovedOutwardCollectionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetLcAmendmentAsync()
    {
        var result = _client.LetterOfCreditService.GetLcAmendmentAsync(LcAmendmentId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateLetterOfCreditAsync()
    {
        var payload = new LetterOfCredit();
        var result = _client.LetterOfCreditService.CreateLetterOfCreditAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateLetterOfCreditAsync()
    {
        var letterOfCreditId = string.Empty;
        var payload = new LetterOfCredit();
        var result = _client.LetterOfCreditService.UpdateLetterOfCreditAsync(letterOfCreditId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetLetterOfCreditAsync()
    {
        var result = _client.LetterOfCreditService.GetLcAmendmentAsync(LetterOfCreditId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void UpdateExternalAmendmentToAnLCAsync()
    {
        var letterOfCreditId = string.Empty;
        var payload = new ExternalAmendmentToAnLC();
        var result = _client.LetterOfCreditService.UpdateExternalAmendmentToAnLCAsync(letterOfCreditId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteLetterOfCreditAsync()
    {
        var letterOfCreditId = string.Empty;
        var payload = new LetterOfCreditDelete();
        var result = _client.LetterOfCreditService.DeleteLetterOfCreditAsync(letterOfCreditId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void ApproveLetterOfCreditAsync()
    {
        var letterOfCreditId = string.Empty;
        var result = _client.LetterOfCreditService.ApproveLetterOfCreditAsync(letterOfCreditId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void RejectLetterOfCreditAsync()
    {
        var letterOfCreditId = string.Empty;
        var payload = new LetterOfCreditDelete();
        var result = _client.LetterOfCreditService.RejectLetterOfCreditAsync(letterOfCreditId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateExportLetterOfCreditAsync()
    {
        var payload = new ExportLetterOfCredit();
        var result = _client.LetterOfCreditService.CreateExportLetterOfCreditAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateExportLetterOfCreditAsync()
    {
        var letterOfCreditId = string.Empty;
        var payload = new ExportLetterOfCredit();
        var result = _client.LetterOfCreditService.UpdateExportLetterOfCreditAsync(letterOfCreditId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateIssuanceOfSightPaymentLCAsync()
    {
        var payload = new IssuanceOfSightPaymentLC();
        var result = _client.LetterOfCreditService.CreateIssuanceOfSightPaymentLCAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateIssuanceOfUsanceLCAsync()
    {
        var payload = new IssuanceOfUsanceLC();
        var result = _client.LetterOfCreditService.CreateIssuanceOfUsanceLCAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateIssuanceOfNegotiationLCAsync()
    {
        var payload = new IssuanceOfNegotiationLC();
        var result = _client.LetterOfCreditService.CreateIssuanceOfNegotiationLCAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateIssuanceOfMixedPaymentLCAsync()
    {
        var payload = new IssuanceOfMixedPaymentLC();
        var result = _client.LetterOfCreditService.CreateIssuanceOfMixedPaymentLCAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateIssuanceOfStandbyLCAsync()
    {
        var payload = new IssuanceOfStandbyLC();
        var result = _client.LetterOfCreditService.CreateIssuanceOfStandbyLCAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateIssuanceOfPreAdviseImportLCAsync()
    {
        var payload = new IssuanceOfPreAdviseImportLC();
        var result = _client.LetterOfCreditService.CreateIssuanceOfPreAdviseImportLCAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateIssuanceOfBackToBackLCAsync()
    {
        var payload = new IssuanceOfBackToBackLC();
        var result = _client.LetterOfCreditService.CreateIssuanceOfBackToBackLCAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateIssuanceOfTransferableLCAsync()
    {
        var payload = new IssuanceOfTransferableLC();
        var result = _client.LetterOfCreditService.CreateIssuanceOfTransferableLCAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateAmendmentSeekingBeneficiaryConsentAsync()
    {
        var letterOfCreditId = string.Empty;
        var payload = new AmendmentSeekingBeneficiaryConsent();
        var result = _client.LetterOfCreditService
            .UpdateAmendmentSeekingBeneficiaryConsentAsync(letterOfCreditId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateDecisionOnAmendmentAsync()
    {
        var letterOfCreditId = string.Empty;
        var payload = new DecisionOnAmendment();
        var result = _client.LetterOfCreditService.UpdateDecisionOnAmendmentAsync(letterOfCreditId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCancellationOfLCAsync()
    {
        var letterOfCreditId = string.Empty;
        var payload = new CancellationOfLC();
        var result = _client.LetterOfCreditService.UpdateCancellationOfLCAsync(letterOfCreditId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateDecisionOnExportLCAmendmentAsync()
    {
        var letterOfCreditId = string.Empty;
        var payload = new DecisionOnExportLCAmendment();
        var result = _client.LetterOfCreditService.UpdateDecisionOnExportLCAmendmentAsync(letterOfCreditId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCancellationOfExportLCAsync()
    {
        var letterOfCreditId = string.Empty;
        var payload = new CancellationOfExportLC();
        var result = _client.LetterOfCreditService.UpdateCancellationOfExportLCAsync(letterOfCreditId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetImportLcsOutstandingAsync()
    {
        var result = _client.LetterOfCreditService.GetImportLcsOutstandingAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetImportLcsExpiringButOutstandingAsync()
    {
        var result = _client.LetterOfCreditService.GetImportLcsExpiringButOutstandingAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetExportlcsOutstandingAsync()
    {
        var result = _client.LetterOfCreditService.GetExportlcsOutstandingAsync(LetterOfCreditId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}