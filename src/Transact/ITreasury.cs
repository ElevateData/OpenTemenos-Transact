using OpenTemenos.Transacts.Holding.CreateNonDeliverableForwards;
using OpenTemenos.Transacts.Holding.CurrencyPositions;
using OpenTemenos.Transacts.Holding.Positions;
using OpenTemenos.Transacts.Holding.Reports;
using OpenTemenos.Transacts.Holding.SwapNpvRevaluations;
using OpenTemenos.Transacts.Holding.TreasuryCurrencies;
using OpenTemenos.Transacts.Holding.TreasuryCurrencyPairs;

namespace OpenTemenos.Transacts;

public interface ITreasury
{
    public ITreasuryCurrencyPairService CurrencyPairService { get; }
    public ISwapNpvRevaluationService InterestRateSwapRevaluationService { get; }
    public ITreasuryCurrencyService LiveRateService { get; }
    public ICreateNonDeliverableForwardService NonDeliverableForwardService { get; }
    public IPositionService PositionService { get; }
    public IReportService ReportService { get; }
    public ICurrencyPositionService CurrencyPositionService { get; }
}
