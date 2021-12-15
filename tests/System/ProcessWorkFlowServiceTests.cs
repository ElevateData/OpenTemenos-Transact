using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.System;

[TestClass]
public class ProcessWorkFlowServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetPendingWorkflowsAsync()
    {
        var result = _client.ProcessWorkFlowService.GetPendingWorkflowsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetWorkflowPendingActivitiesAsync()
    {
        var result = _client.ProcessWorkFlowService.GetWorkflowPendingActivitiesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetTransactionsAsync()
    {
        var result = _client.ProcessWorkFlowService.GetTransactionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetRolelessTransactionsAsync()
    {
        var result = _client.ProcessWorkFlowService.GetRolelessTransactionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetWorkflowParticipantsAsync()
    {
        var result = _client.ProcessWorkFlowService.GetWorkflowParticipantsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}