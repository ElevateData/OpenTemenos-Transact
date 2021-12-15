using OpenTemenos.Transacts.Holding;
using OpenTemenos.Transacts.Holding.CreateNonDeliverableForwards;
using OpenTemenos.Transacts.Holding.CurrencyPositions;
using OpenTemenos.Transacts.Holding.Positions;
using OpenTemenos.Transacts.Holding.Reports;
using OpenTemenos.Transacts.Holding.SwapNpvRevaluations;
using OpenTemenos.Transacts.Holding.TreasuryCurrencies;
using OpenTemenos.Transacts.Holding.TreasuryCurrencyPairs;

namespace OpenTemenos.Transacts;

public class Treasury : ITreasury
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public Treasury(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ITreasuryCurrencyPairService CurrencyPairService => new TreasuryCurrencyPairService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISwapNpvRevaluationService InterestRateSwapRevaluationService => new SwapNpvRevaluationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITreasuryCurrencyService LiveRateService => new TreasuryCurrencyService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICreateNonDeliverableForwardService NonDeliverableForwardService =>
        new CreateNonDeliverableForwardService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPositionService PositionService => new PositionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IReportService ReportService => new ReportService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICurrencyPositionService CurrencyPositionService => new CurrencyPositionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
