using OpenTemenos.Transacts.Order;
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

public class OrderClient : IOrderClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public OrderClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAccountTransferService AccountFundTransferService => new AccountTransferService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICashManagementSweepService CashManagementSweepService => new CashManagementSweepService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICreditorReferenceService CreditorReferenceService => new CreditorReferenceService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDerivativeOrderService DerivativeInstrumentOrderService => new DerivativeOrderService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFiduciaryOrderService FiduciaryOrderService => new FiduciaryOrderService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IForexCustomerOrderService TreasuryForexOrderService => new ForexCustomerOrderService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IIPOSecurityOrderService InitialPublicOfferingSecurityOrderService => new IPOSecurityOrderService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOrderSimulationService SecurityOrderSimulationService => new OrderSimulationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPositionTransferOrdersRequestService SecurityPositionTransferService => new PositionTransferOrdersRequestService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPrivateEquityOrderService PrivateEquityOrderService => new PrivateEquityOrderService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPaymentsConfigurationService PaymentConfigurationService => new PaymentsConfigurationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISecurityOrderService SecurityOrderService => new SecurityOrderService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISecurityTransferOrderService SecurityTransferService => new SecurityTransferOrderService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISweepService AccountSweepService => new SweepService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
