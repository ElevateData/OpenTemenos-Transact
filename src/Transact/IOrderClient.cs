using OpenTemenos.Transacts.Order.AccountTransfers;
using OpenTemenos.Transacts.Order.CashManagementSweeps;
using OpenTemenos.Transacts.Order.CreditorReferences;
using OpenTemenos.Transacts.Order.DerivativeOrders;
using OpenTemenos.Transacts.Order.FiduciaryOrders;
using OpenTemenos.Transacts.Order.ForexCustomerOrders;
using OpenTemenos.Transacts.Order.IPOSecurityOrders;
using OpenTemenos.Transacts.Order.OrderSimulations;
using OpenTemenos.Transacts.Order.PaymentsConfigurations;
using OpenTemenos.Transacts.Order.PositionTransferOrdersRequests;
using OpenTemenos.Transacts.Order.PrivateEquityOrders;
using OpenTemenos.Transacts.Order.SecurityOrders;
using OpenTemenos.Transacts.Order.SecurityTransferOrders;
using OpenTemenos.Transacts.Order.Sweeps;

namespace OpenTemenos.Transacts;

public interface IOrderClient
{
    public IAccountTransferService AccountFundTransferService { get; }
    //public ICashManagementBundleService CashManagementBundleService { get; }
    public ICashManagementSweepService CashManagementSweepService { get; }
    public ICreditorReferenceService CreditorReferenceService { get; }
    public IDerivativeOrderService DerivativeInstrumentOrderService { get; }
    public IFiduciaryOrderService FiduciaryOrderService { get; }
    public IIPOSecurityOrderService InitialPublicOfferingSecurityOrderService { get; }
    public ISweepService AccountSweepService { get; }
    public IPrivateEquityOrderService PrivateEquityOrderService { get; }
    public IPaymentsConfigurationService PaymentConfigurationService { get; }
    public ISecurityOrderService SecurityOrderService { get; }
    public IOrderSimulationService SecurityOrderSimulationService { get; }
    public IPositionTransferOrdersRequestService SecurityPositionTransferService { get; }
    public ISecurityTransferOrderService SecurityTransferService { get; }
    public IForexCustomerOrderService TreasuryForexOrderService { get; }
    //public IUsPaymentService UsModelBankPaymentService { get; }


    //public IPaymentsConfigurationService PaymentsConfigurationService { get; }
}