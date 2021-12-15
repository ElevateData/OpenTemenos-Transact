using OpenTemenos.Transacts.Holding;
using OpenTemenos.Transacts.Holding.Accounts;
using OpenTemenos.Transacts.Holding.Alerts;
using OpenTemenos.Transacts.Holding.ArrangementsActivities;
using OpenTemenos.Transacts.Holding.ArrangementsBalances;
using OpenTemenos.Transacts.Holding.ArrangementsProductLines;
using OpenTemenos.Transacts.Holding.Cards;
using OpenTemenos.Transacts.Holding.CashManagementBundles;
using OpenTemenos.Transacts.Holding.Collaterals;
using OpenTemenos.Transacts.Holding.CreateNonDeliverableForwards;
using OpenTemenos.Transacts.Holding.CurrencyPositions;
using OpenTemenos.Transacts.Holding.CustomerArrangements;
using OpenTemenos.Transacts.Holding.Customers;
using OpenTemenos.Transacts.Holding.Dashboards;
using OpenTemenos.Transacts.Holding.Deposits;
using OpenTemenos.Transacts.Holding.DerivativesOptions;
using OpenTemenos.Transacts.Holding.Entitlements;
using OpenTemenos.Transacts.Holding.ForexUtilizations;
using OpenTemenos.Transacts.Holding.Guarantees;
using OpenTemenos.Transacts.Holding.LetterOfCredits;
using OpenTemenos.Transacts.Holding.Limits;
using OpenTemenos.Transacts.Holding.PaymentStops;
using OpenTemenos.Transacts.Holding.Portfolios;
using OpenTemenos.Transacts.Holding.PortfolioSettlements;
using OpenTemenos.Transacts.Holding.Positions;
using OpenTemenos.Transacts.Holding.Reports;
using OpenTemenos.Transacts.Holding.RepurchaseAgreements;
using OpenTemenos.Transacts.Holding.SecurityPositions;
using OpenTemenos.Transacts.Holding.SecurityTrades;
using OpenTemenos.Transacts.Holding.Services;
using OpenTemenos.Transacts.Holding.SwapNpvRevaluations;
using OpenTemenos.Transacts.Holding.Transactions;
using OpenTemenos.Transacts.Holding.TreasuryCurrencies;
using OpenTemenos.Transacts.Holding.TreasuryCurrencyPairs;

namespace OpenTemenos.Transacts;

public class HoldingClient : IHoldingClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public HoldingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public ICardService AccountCardService => new CardService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAccountService AccountManagementService => new AccountService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IArrangementsActivityService ArrangementsActivityService => new ArrangementsActivityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICashManagementBundleService CashManagementBundleArrangementService => new CashManagementBundleService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEntitlementService CorporateActionEventManagementService => new EntitlementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IDashboardService CorporateDashboardService => new DashboardService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    [Obsolete("All methods are obsolete")]
    public IDepositService DepositService => new DepositService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICurrencyPositionService CurrencyPositionService => new CurrencyPositionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICustomerArrangementService CustomerArrangementService => new CustomerArrangementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICustomerService CustomerHoldingService => new CustomerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IDerivativesOptionService DerivativeInstrumentOperationService => new DerivativesOptionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ILimitService LimitLiabilityAndForexLimitService => new LimitService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IHoldingService HoldingService => new HoldingService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IArrangementsProductLineService ArrangementForProductLineService => new ArrangementsProductLineService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAlertService ArrangementAccountAlertService => new AlertService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IArrangementsBalanceService ArrangementAccountDocumentService => new ArrangementsBalanceService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICollateralService CustomerCollateralService => new CollateralService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICreateNonDeliverableForwardService CreateNonDeliverableForwardService => new CreateNonDeliverableForwardService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IForexUtilizationService ForexUtilizationService => new ForexUtilizationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IGuaranteeService GuaranteeService => new GuaranteeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ILetterOfCreditService LetterOfCreditService => new LetterOfCreditService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPaymentStopService PaymentStopService => new PaymentStopService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPortfolioService PortfolioService => new PortfolioService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPositionService PositionService => new PositionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IReportService ReportService => new ReportService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRepurchaseAgreementService RepurchaseAgreementService => new RepurchaseAgreementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityPositionService SecurityPositionService => new SecurityPositionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPortfolioSettlementService SecuritySettlementService => new PortfolioSettlementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityTradeService SecurityTradeService => new SecurityTradeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISwapNpvRevaluationService SwapNpvRevaluationService => new SwapNpvRevaluationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITransactionService TransactionService => new TransactionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITreasury Treasury => new Treasury(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITreasuryCurrencyService TreasuryCurrencyService => new TreasuryCurrencyService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITreasuryCurrencyPairService TreasuryCurrencyPairService => new TreasuryCurrencyPairService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUsModelBank UsModelBank => new UsModelBank(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
