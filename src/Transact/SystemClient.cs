using OpenTemenos.Transacts.System;
using OpenTemenos.Transacts.System.CloudServiceElasticities;
using OpenTemenos.Transacts.System.DataEventStreamings;
using OpenTemenos.Transacts.System.DocumentRequireds;
using OpenTemenos.Transacts.System.ExternalAccountings;
using OpenTemenos.Transacts.System.OnlineUpgrades;
using OpenTemenos.Transacts.System.ProcessWorkFlows;
using OpenTemenos.Transacts.System.ServiceAutomations;
using OpenTemenos.Transacts.System.SPFInformations;
using OpenTemenos.Transacts.System.UsageStatistics;

namespace OpenTemenos.Transacts;

public class SystemClient : ISystemClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public SystemClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ICloudServiceElasticityService CloudServiceElasticityService => new CloudServiceElasticityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDataEventStreamingService DataEventStreamingService => new DataEventStreamingService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IExternalAccountingService ExternalAccountingService => new ExternalAccountingService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDocumentRequiredService DocumentRequiredService => new DocumentRequiredService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISPFInformationService SPFInformationService => new SPFInformationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsageStatisticService UsageStatisticService => new UsageStatisticService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOnlineUpgradeService OnlineUpgradeService => new OnlineUpgradeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IProcessWorkFlowService ProcessWorkFlowService => new ProcessWorkFlowService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IServiceAutomationService ServiceAutomationService => new ServiceAutomationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
