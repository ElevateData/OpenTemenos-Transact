namespace OpenTemenos.Transacts;

public class LoanClient : ILoanClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public LoanClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
}
