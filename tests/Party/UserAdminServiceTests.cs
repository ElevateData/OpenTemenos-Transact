using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Party.UserAdmins;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class UserAdminServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private const string ExternalUserId = "2";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void GetUsCustomerInformationAsync()
    {
        var payload = new ExternalUserCustomer();
        var result = _client.UserAdminService.CreateExternalUserCustomerAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetExternalUserAsync()
    {
        var result = _client.UserAdminService.GetExternalUserAsync(ExternalUserId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateExternalUserAsync()
    {
        var externalUserId = string.Empty;
        var payload = new ExternalUser();
        var result = _client.UserAdminService.CreateExternalUserAsync(externalUserId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateExternalUserAsync()
    {
        var externalUserId = string.Empty;
        var payload = new ExternalUser();
        var result = _client.UserAdminService.UpdateExternalUserAsync(externalUserId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteExternalUserAsync()
    {
        var externalUserId = string.Empty;
        var payload = new ExternalUserDelete();
        var result = _client.UserAdminService.DeleteExternalUserAsync(externalUserId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void InitiateExternalUserAsync()
    {
        var payload = new ExternalUser();
        var result = _client.UserAdminService.InitiateExternalUserAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void AmendExternalUserAsync()
    {
        var externalUserId = string.Empty;
        var payload = new ExternalUser();
        var result = _client.UserAdminService.AmendExternalUserAsync(externalUserId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void ApproveExternalUserAsync()
    {
        var externalUserId = string.Empty;
        var result = _client.UserAdminService.ApproveExternalUserAsync(externalUserId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void RejectExternalUserAsync()
    {
        var externalUserId = string.Empty;
        var payload = new ExternalUserDelete();
        var result = _client.UserAdminService.RejectExternalUserAsync(externalUserId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void InitiateExternalUserDeleteAsync()
    {
        var externalUserId = string.Empty;
        var payload = new ExternalUserDeleteDelete();
        var result = _client.UserAdminService.InitiateExternalUserDeleteAsync(externalUserId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetExternalUserApprovalsAsync()
    {
        var result = _client.UserAdminService.GetExternalUserApprovalsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerExternalUsersAsync()
    {
        var result = _client.UserAdminService.GetCustomerExternalUsersAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetExternalUsersAsync()
    {
        var result = _client.UserAdminService.GetExternalUsersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerRelationsAsync()
    {
        var result = _client.UserAdminService.GetCustomerRelationsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetUserProfileAsync()
    {
        var result = _client.UserAdminService.GetUserProfileAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}