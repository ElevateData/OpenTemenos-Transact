namespace OpenTemenos.Transacts;

public class OpenTemenosTransactClient : IOpenTemenosTransactClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public OpenTemenosTransactClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IEnterpriseClient Enterprise => new EnterpriseClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IHoldingClient Holding => new HoldingClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ILoanClient Loan => new LoanClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IMetaClient Meta => new MetaClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IMicroserviceClient Microservice => new MicroserviceClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOrderClient Order => new OrderClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPartyClient Party => new PartyClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IProductClient Product => new ProductClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IReferenceClient Reference => new ReferenceClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISystemClient System => new SystemClient(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
