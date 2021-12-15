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

public interface ISystemClient
{
    public ICloudServiceElasticityService CloudServiceElasticityService { get; }
    public IDataEventStreamingService DataEventStreamingService { get; }
    public IExternalAccountingService ExternalAccountingService { get; }
    public IDocumentRequiredService DocumentRequiredService { get; }
    public ISPFInformationService SPFInformationService { get; }
    public IUsageStatisticService UsageStatisticService { get; }
    public IOnlineUpgradeService OnlineUpgradeService { get; }
    public IProcessWorkFlowService ProcessWorkFlowService { get; }
    public IServiceAutomationService ServiceAutomationService { get; }
}