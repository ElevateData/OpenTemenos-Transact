//using OpenTemenos.Transacts.Holding.Arrangements;

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

public interface IHoldingClient
{
    public ICardService AccountCardService { get; }
    public IAccountService AccountManagementService { get; }
    [Obsolete("All methods are obsolete")]
    public IArrangementsActivityService ArrangementsActivityService { get; }
    //public IArrangementService ArrangementDetailService { get; }
    public ICashManagementBundleService CashManagementBundleArrangementService { get; }
    //public IUserAdminService ChannelUserAdministrationService {get;}
    public IEntitlementService CorporateActionEventManagementService { get; }
    //public ICreditAgreementsApiService CorporateCreditAgreementService {get;}
    public IDashboardService CorporateDashboardService { get; }
    public IDepositService DepositService { get; }
    //public ILoansArrangementService LoanCreationService {get;}
    public ICurrencyPositionService CurrencyPositionService { get; }
    //public IAccountsArrangementService CustomerArrangementAccountService { get; }
    public ICustomerArrangementService CustomerArrangementService { get; }
    public ICustomerService CustomerHoldingService { get; }
    public IDerivativesOptionService DerivativeInstrumentOperationService { get; }
    //public ICalculatePayoffService InitialLoanPayoffService { get; }
    //public IUpdatePaymentHolidayService UpdatePaymentHolidayService { get; }
    public ILimitService LimitLiabilityAndForexLimitService { get; }
    public IHoldingService HoldingService { get; }
    public IArrangementsProductLineService ArrangementForProductLineService { get; }
    //public ILoansArrangementService LoansCreationService { get; }
    public IAlertService ArrangementAccountAlertService { get; }
    [Obsolete("All methods are obsolete")]
    public IArrangementsBalanceService ArrangementAccountDocumentService { get; }
    public ICollateralService CustomerCollateralService { get; }
    public ICreateNonDeliverableForwardService CreateNonDeliverableForwardService { get; }
    public IForexUtilizationService ForexUtilizationService { get; }
    public IGuaranteeService GuaranteeService { get; }
    public ILetterOfCreditService LetterOfCreditService { get; }
    public IPaymentStopService PaymentStopService { get; }
    public IPortfolioService PortfolioService { get; }
    public IPositionService PositionService { get; }
    public IReportService ReportService { get; }
    public IRepurchaseAgreementService RepurchaseAgreementService { get; }
    public ISecurityPositionService SecurityPositionService { get; }
    public IPortfolioSettlementService SecuritySettlementService { get; }
    public ISecurityTradeService SecurityTradeService { get; }
    public ISwapNpvRevaluationService SwapNpvRevaluationService { get; }
    //public IUpdatePaymentHolidaySimulationService UpdatePaymentHolidaySimulationService { get; }
    public ITransactionService TransactionService { get; }
    public ITreasury Treasury { get; }
    public ITreasuryCurrencyService TreasuryCurrencyService { get; }
    public ITreasuryCurrencyPairService TreasuryCurrencyPairService { get; }
    public IUsModelBank UsModelBank { get; }

    //Not sure if this item is being used by Temenos
    //public IDepositService DepositService { get; }
}