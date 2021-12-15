using OpenTemenos.Transacts.Microservice;
using OpenTemenos.Transacts.Microservice.CallbackRegistries;
using OpenTemenos.Transacts.Microservice.Entitlements;
using OpenTemenos.Transacts.Microservice.GenericConfigs;
using OpenTemenos.Transacts.Microservice.Meterings;
using OpenTemenos.Transacts.Microservice.ServiceOrchestrators;
using OpenTemenos.Transacts.Microservice.Traceabilities;

namespace OpenTemenos.Transacts;

public class MicroserviceClient : IMicroserviceClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public MicroserviceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ICallbackRegistryService CallbackRegistryService => new CallbackRegistryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IEntitlementService EntitlementService => new EntitlementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IGenericConfigService ConfigurationService => new GenericConfigService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IMeteringService ApplicationMeteringService => new MeteringService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IServiceOrchestratorService ServiceOrchestratorService => new ServiceOrchestratorService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITraceabilityService TraceabilityService => new TraceabilityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
