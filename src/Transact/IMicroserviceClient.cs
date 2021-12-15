using OpenTemenos.Transacts.Microservice.CallbackRegistries;
using OpenTemenos.Transacts.Microservice.Entitlements;
using OpenTemenos.Transacts.Microservice.GenericConfigs;
using OpenTemenos.Transacts.Microservice.Meterings;
using OpenTemenos.Transacts.Microservice.ServiceOrchestrators;
using OpenTemenos.Transacts.Microservice.Traceabilities;

namespace OpenTemenos.Transacts;

public interface IMicroserviceClient
{
    public IMeteringService ApplicationMeteringService { get; }
    public ICallbackRegistryService CallbackRegistryService { get; }
    public IGenericConfigService ConfigurationService { get; }
    public IEntitlementService EntitlementService { get; }
    //public IEventStoreService EventStoreService { get; }

    public IServiceOrchestratorService ServiceOrchestratorService { get; }
    public ITraceabilityService TraceabilityService { get; }

}