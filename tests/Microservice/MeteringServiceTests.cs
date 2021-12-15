using System;
using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Microservice.Meterings;

namespace OpenTemenos.Tests.Transact.Microservice;

[TestClass]
public class MeteringServiceTests : CredentialManagement
{
    private const string ApplicationId = "1";
    private const string ConfigurationId = "1";
    private const string ResourceId = "1";
    private const string MetricId = "1";
    private readonly IMicroserviceClient _client = new MicroserviceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetAppMetricConfigAsync()
    {
        var result = _client.ApplicationMeteringService.GetAppMetricConfigAsync(ApplicationId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateAppMeteringConfigAsync()
    {
        var applicationId = string.Empty;
        var body = new MeteringAppConfiguration();
        var result = _client.ApplicationMeteringService.CreateAppMeteringConfigAsync(applicationId, body)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetApplicationMetricsConfigAsync()
    {
        var result = _client.ApplicationMeteringService.GetApplicationMetricsConfigAsync(ConfigurationId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateAppMeteringConfigAsync()
    {
        var configurationId = string.Empty;
        var body = new MeteringUpdateConfiguration();
        var result = _client.ApplicationMeteringService.UpdateAppMeteringConfigAsync(configurationId, body)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteAppMeteringConfigAsync()
    {
        var configurationId = string.Empty;
        var result = _client.ApplicationMeteringService.DeleteAppMeteringConfigAsync(configurationId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetMetricLogDataAsync()
    {
        var fromDate = DateTimeOffset.Parse("1 Jan 2020");
        var toDate = DateTimeOffset.Parse("1 Jan 2021");
        var result = _client.ApplicationMeteringService.GetMetricLogDataAsync(ApplicationId, fromDate, toDate)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void AddMetricDataAsync()
    {
        var requestId = Guid.Empty;
        var applicationId = string.Empty;
        var body = Array.Empty<MetricDataLog>();
        var result = _client.ApplicationMeteringService.AddMetricDataAsync(requestId, applicationId, body)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetUsageStatisticsAsync()
    {
        var fromDate = DateTimeOffset.Parse("1 Jan 2020");
        var toDate = DateTimeOffset.Parse("1 Jan 2021");
        var result = _client.ApplicationMeteringService.GetUsageStatisticsAsync(ApplicationId, fromDate, toDate)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetEvidenceAsync()
    {
        var result = _client.ApplicationMeteringService.GetEvidenceAsync(ApplicationId, ResourceId, MetricId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }
}