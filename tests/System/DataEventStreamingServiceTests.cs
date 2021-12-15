using OpenTemenos.Transacts;
using OpenTemenos.Transacts.System.DataEventStreamings;

namespace OpenTemenos.Tests.Transact.System;

[TestClass]
public class DataEventStreamingServiceTests : CredentialManagement
{
    private const string CompanyMnemonic = "1";
    private const string ApplicationName = "1";
    private const string PatternType = "1";
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetFileNamesAsync()
    {
        var result = _client.DataEventStreamingService.GetFileNamesAsync(CompanyMnemonic, ApplicationName, PatternType)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void ConfigureDESAsync()
    {
        var settingId = string.Empty;
        var payload = new DES();
        var result = _client.DataEventStreamingService.ConfigureDESAsync(settingId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void EnableCommitCaptureAsync()
    {
        var settingId = string.Empty;
        var payload = new CommitCapture();
        var result = _client.DataEventStreamingService.EnableCommitCaptureAsync(settingId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetCommitCaptureEnabledAsync()
    {
        var result = _client.DataEventStreamingService.GetCommitCaptureEnabledAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetUnprocessedCountAsync()
    {
        var result = _client.DataEventStreamingService.GetUnprocessedCountAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}