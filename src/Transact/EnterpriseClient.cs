using OpenTemenos.Transacts.Enterprise;
using OpenTemenos.Transacts.Enterprise.Pricings;

namespace OpenTemenos.Transacts;

public class EnterpriseClient : IEnterpriseClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public EnterpriseClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IPricingService EnterpriseProductPricingService => new PricingService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
