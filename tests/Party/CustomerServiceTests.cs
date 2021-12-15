using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Party.Customers;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomerServiceTests : CredentialManagement
{
    private const string AddressId = "1";
    private const string CustomerId = "100282";
    private const string CustomerExitStatusId = "1";
    private const string PartyId = "1";
    private const string PortfolioId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerMandatesAsync()
    {
        var result = _client.CustomerService.GetCustomerMandatesAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetDocumentsLocationAsync()
    {
        var result = _client.CustomerService.GetCustomerAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCustomerAsync()
    {
        var customerId = string.Empty;
        var payload = new Customer();
        var result = _client.CustomerService.UpdateCustomerAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetCustomerInformationAsync()
    {
        var result = _client.CustomerService.GetCustomerInformationAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateCustomerAsync()
    {
        var payload = new Customer();
        var result = _client.CustomerService.CreateCustomerAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetCustomerRelationshipAsync()
    {
        var result = _client.CustomerService.GetCustomerRelationshipAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateCustomerRelationshipAsync()
    {
        var payload = new CustomerRelationship();
        var result = _client.CustomerService.CreateCustomerRelationshipAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCustomerRelationshipAsync()
    {
        var relationId = string.Empty;
        var payload = new CustomerRelationship();
        var result = _client.CustomerService.UpdateCustomerRelationshipAsync(relationId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerReportingStatusAsync()
    {
        var result = _client.CustomerService.GetCustomerReportingStatusAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerSweepsAsync()
    {
        var result = _client.CustomerService.GetCustomerSweepsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerDeliveryOptionsAsync()
    {
        var result = _client.CustomerService.GetCustomerDeliveryOptionsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerDigitalChannelsAsync()
    {
        var result = _client.CustomerService.GetCustomerDigitalChannelsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateMessagesAsync()
    {
        var payload = new Messages();
        var result = _client.CustomerService.CreateMessagesAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetJointCustomerDetailsAsync()
    {
        var result = _client.CustomerService.GetJointCustomerDetailsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerKYCDetailsAsync()
    {
        var result = _client.CustomerService.GetCustomerKYCDetailsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerPersonalDetailsAsync()
    {
        var result = _client.CustomerService.GetCustomerPersonalDetailsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerPostingRestrictionsAsync()
    {
        var result = _client.CustomerService.GetCustomerPostingRestrictionsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreatePartyRelationshipAsync()
    {
        var relationId = string.Empty;
        var payload = new PartyRelationship();
        var result = _client.CustomerService.CreatePartyRelationshipAsync(relationId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdatePartyRelationshipAsync()
    {
        var relationId = string.Empty;
        var payload = new PartyRelationship();
        var result = _client.CustomerService.UpdatePartyRelationshipAsync(relationId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerCreditCardsAsync()
    {
        var result = _client.CustomerService.GetCustomerCreditCardsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetStandingOrdersAsync()
    {
        var result = _client.CustomerService.GetStandingOrdersAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetDirectDebitsAsync()
    {
        var result = _client.CustomerService.GetDirectDebitsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateDeliveryPreferenceAsync()
    {
        var deliveryPreferenceId = string.Empty;
        var payload = new DeliveryPreference();
        var result = _client.CustomerService.CreateDeliveryPreferenceAsync(deliveryPreferenceId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateDeliveryPreferenceAsync()
    {
        var deliveryPreferenceId = string.Empty;
        var payload = new DeliveryPreference();
        var result = _client.CustomerService.UpdateDeliveryPreferenceAsync(deliveryPreferenceId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateLimitAsync()
    {
        var limitId = string.Empty;
        var payload = new Limit();
        var result = _client.CustomerService.UpdateLimitAsync(limitId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerExitStatusAsync()
    {
        var result = _client.CustomerService.GetCustomerExitStatusAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCustomerExitStatusAsync()
    {
        var customerId = string.Empty;
        var payload = new CustomerExitStatus();
        var result = _client.CustomerService.UpdateCustomerExitStatusAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerExitStatusParamAsync()
    {
        var result = _client.CustomerService.GetCustomerExitStatusParamAsync(CustomerExitStatusId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateCustomerExitStatusParamAsync()
    {
        var customerExitStatusId = string.Empty;
        var payload = new CustomerExitStatusParam();
        var result = _client.CustomerService.CreateCustomerExitStatusParamAsync(customerExitStatusId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCustomerExitStatusParamAsync()
    {
        var customerExitStatusId = string.Empty;
        var payload = new CustomerExitStatusParam();
        var result = _client.CustomerService.UpdateCustomerExitStatusParamAsync(customerExitStatusId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerAddressOutputAsync()
    {
        var result = _client.CustomerService.GetCustomerAddressOutputAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerShortNamesAsync()
    {
        var result = _client.CustomerService.GetCustomerShortNamesAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerLegalDocumentsAsync()
    {
        var result = _client.CustomerService.GetCustomerLegalDocumentsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerProfileAsync()
    {
        var result = _client.CustomerService.GetCustomerProfileAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerIdAsync()
    {
        var result = _client.CustomerService.GetCustomerIdAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerRestrictionsAsync()
    {
        var result = _client.CustomerService.GetCustomerRestrictionsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerContactsAsync()
    {
        var result = _client.CustomerService.GetCustomerContactsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerRelationshipsAsync()
    {
        var result = _client.CustomerService.GetCustomerRelationshipsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPartyBasicDetailsAsync()
    {
        var result = _client.CustomerService.GetPartyBasicDetailsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerSwiftAddressAsync()
    {
        var result = _client.CustomerService.GetCustomerSwiftAddressAsync(CustomerId, AddressId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetPartyRelationshipAsync()
    {
        var result = _client.CustomerService.GetPartyRelationshipAsync(PartyId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerChargeAsync()
    {
        var result = _client.CustomerService.GetCustomerChargeAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateCustomerChargeAsync()
    {
        var customerId = string.Empty;
        var payload = new CustomerCharge();
        var result = _client.CustomerService.CreateCustomerChargeAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCustomerChargeAsync()
    {
        var customerId = string.Empty;
        var payload = new CustomerCharge();
        var result = _client.CustomerService.UpdateCustomerChargeAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerPhoneAddressAsync()
    {
        var result = _client.CustomerService.GetCustomerPhoneAddressAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateCustomerPhoneAddressAsync()
    {
        var customerId = string.Empty;
        var payload = new CustomerPhoneAddress();
        var result = _client.CustomerService.CreateCustomerPhoneAddressAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerEmailAddressAsync()
    {
        var result = _client.CustomerService.GetCustomerEmailAddressAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateCustomerEmailAddressAsync()
    {
        var customerId = string.Empty;
        var payload = new CustomerEmailAddress();
        var result = _client.CustomerService.CreateCustomerEmailAddressAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerPrintAddressAsync()
    {
        var result = _client.CustomerService.GetCustomerPrintAddressAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateCustomerPrintAddressAsync()
    {
        var customerId = string.Empty;
        var payload = new CustomerPrintAddress();
        var result = _client.CustomerService.CreateCustomerPrintAddressAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCustomerPhoneAddressAsync()
    {
        var customerAddressId = string.Empty;
        var payload = new CustomerPhoneAddress();
        var result = _client.CustomerService.UpdateCustomerPhoneAddressAsync(customerAddressId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteCustomerPhoneAddressAsync()
    {
        var customerAddressId = string.Empty;
        var payload = new CustomerPhoneAddressDelete();
        var result = _client.CustomerService.DeleteCustomerPhoneAddressAsync(customerAddressId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCustomerEmailAddressAsync()
    {
        var customerAddressId = string.Empty;
        var payload = new CustomerEmailAddress();
        var result = _client.CustomerService.UpdateCustomerEmailAddressAsync(customerAddressId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteCustomerEmailAddressAsync()
    {
        var customerAddressId = string.Empty;
        var payload = new CustomerEmailAddressDelete();
        var result = _client.CustomerService.DeleteCustomerEmailAddressAsync(customerAddressId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateCustomerPrintAddressAsync()
    {
        var customerAddressId = string.Empty;
        var payload = new CustomerPrintAddress();
        var result = _client.CustomerService.UpdateCustomerPrintAddressAsync(customerAddressId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteCustomerPrintAddressAsync()
    {
        var customerAddressId = string.Empty;
        var payload = new CustomerPrintAddressDelete();
        var result = _client.CustomerService.DeleteCustomerPrintAddressAsync(customerAddressId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerConsentsAsync()
    {
        var result = _client.CustomerService.GetCustomerConsentsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateFatcaCustomerAsync()
    {
        var customerId = string.Empty;
        var payload = new FatcaCustomer();
        var result = _client.CustomerService.CreateFatcaCustomerAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateFatcaCustomerAsync()
    {
        var customerId = string.Empty;
        var payload = new FatcaCustomer();
        var result = _client.CustomerService.UpdateFatcaCustomerAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetOverdueSettlementsAsync()
    {
        var result = _client.CustomerService.GetOverdueSettlementsAsync(CustomerId, PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetOtherBanksToConnectToAsync()
    {
        var result = _client.CustomerService.GetOtherBanksToConnectToAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetProspectCustomersAsync()
    {
        var result = _client.CustomerService.GetProspectCustomersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateProspectCustomerAsync()
    {
        var payload = new ProspectCustomer();
        var result = _client.CustomerService.CreateProspectCustomerAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerOpportunitiesAsync()
    {
        var result = _client.CustomerService.GetCustomerOpportunitiesAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerRequestsAsync()
    {
        var result = _client.CustomerService.GetCustomerRequestsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateProspectCustomerAsync()
    {
        var prospectId = string.Empty;
        var payload = new ProspectCustomer();
        var result = _client.CustomerService.UpdateProspectCustomerAsync(prospectId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetAlertRequestsAsync()
    {
        var result = _client.CustomerService.GetAlertRequestsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}