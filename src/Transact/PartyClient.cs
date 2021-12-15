using OpenTemenos.Transacts.Party;
using OpenTemenos.Transacts.Party.Beneficiaries;
using OpenTemenos.Transacts.Party.CustomerAdverts;
using OpenTemenos.Transacts.Party.CustomerArrangements;
using OpenTemenos.Transacts.Party.CustomerDeliveryPreferences;
using OpenTemenos.Transacts.Party.CustomerMandates;
using OpenTemenos.Transacts.Party.CustomerOpenBankingConnections;
using OpenTemenos.Transacts.Party.Customers;
using OpenTemenos.Transacts.Party.CustomersContactHistories;
using OpenTemenos.Transacts.Party.CustomersDocuments;
using OpenTemenos.Transacts.Party.CustomersMiFIDs;
using OpenTemenos.Transacts.Party.ExternalUsers;
using OpenTemenos.Transacts.Party.OnboardingCustomers;
using OpenTemenos.Transacts.Party.ParticipantLists;
using OpenTemenos.Transacts.Party.SaasBeneficiaries;
using OpenTemenos.Transacts.Party.SecuritiesCustomers;
using OpenTemenos.Transacts.Party.TravelNotifications;
using OpenTemenos.Transacts.Party.UsCustomerInformations;
using OpenTemenos.Transacts.Party.UserAdmins;

namespace OpenTemenos.Transacts;

public class PartyClient : IPartyClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public PartyClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IBeneficiaryService BeneficiaryService => new BeneficiaryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomerAdvertService CustomerAdvertService => new CustomerAdvertService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomerArrangementService CustomerArrangementService => new CustomerArrangementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomerDeliveryPreferenceService CustomerDeliveryPreferenceService => new CustomerDeliveryPreferenceService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomerMandateService CustomerMandateService => new CustomerMandateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomerOpenBankingConnectionService CustomerOpenBankingConnectionService => new CustomerOpenBankingConnectionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomersContactHistoryService CustomersContactHistoryService => new CustomersContactHistoryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomersDocumentService CustomersDocumentService => new CustomersDocumentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomerService CustomerService => new CustomerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomersMiFIDService CustomersMiFIDService => new CustomersMiFIDService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IExternalUserService ExternalUserService => new ExternalUserService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOnboardingCustomerService OnboardingCustomerService => new OnboardingCustomerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IParticipantListService ParticipantListService => new ParticipantListService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISaasBeneficiaryService SaasBeneficiaryService => new SaasBeneficiaryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISecuritiesCustomerService SecuritiesCustomerService => new SecuritiesCustomerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITravelNotificationService TravelNotificationService => new TravelNotificationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsCustomerInformationService UsCustomerInformationService => new UsCustomerInformationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUserAdminService UserAdminService => new UserAdminService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
