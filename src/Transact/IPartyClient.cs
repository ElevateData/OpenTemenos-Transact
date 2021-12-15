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

//TODO: Rename Transact.IPartyClient methods
public interface IPartyClient
{
    public IBeneficiaryService BeneficiaryService { get; }
    public ICustomerAdvertService CustomerAdvertService { get; }
    public ICustomerArrangementService CustomerArrangementService { get; }
    public ICustomerDeliveryPreferenceService CustomerDeliveryPreferenceService { get; }
    public ICustomerMandateService CustomerMandateService { get; }
    public ICustomerOpenBankingConnectionService CustomerOpenBankingConnectionService { get; }
    public ICustomersContactHistoryService CustomersContactHistoryService { get; }
    public ICustomersDocumentService CustomersDocumentService { get; }
    public ICustomerService CustomerService { get; }
    public ICustomersMiFIDService CustomersMiFIDService { get; }
    public IExternalUserService ExternalUserService { get; }
    public IOnboardingCustomerService OnboardingCustomerService { get; }
    public IParticipantListService ParticipantListService { get; }
    public ISaasBeneficiaryService SaasBeneficiaryService { get; }
    public ISecuritiesCustomerService SecuritiesCustomerService { get; }
    public ITravelNotificationService TravelNotificationService { get; }
    public IUsCustomerInformationService UsCustomerInformationService { get; }
    public IUserAdminService UserAdminService { get; }
}