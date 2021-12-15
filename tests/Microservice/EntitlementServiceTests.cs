using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Microservice.Entitlements;

namespace OpenTemenos.Tests.Transact.Microservice;

[TestClass]
public class EntitlementServiceTests : CredentialManagement
{
    private const string UserId = "1";
    private const string ResourceId = "1";
    private readonly IMicroserviceClient _client = new MicroserviceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetEntitlementsAsync()
    {
        var result = _client.EntitlementService.GetEntitlementsAsync(UserId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetUserEntitlementsAsync()
    {
        var result = _client.EntitlementService.GetUserEntitlementsAsync(UserId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetEntitlementsWithActionsAsync()
    {
        var result = _client.EntitlementService.GetEntitlementsWithActionsAsync(UserId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void AddEntitlementsAsync()
    {
        var userId = string.Empty;
        var resourceId = string.Empty;
        var body = new Roles();
        var result = _client.EntitlementService.AddEntitlementsAsync(userId, resourceId, body)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetUserEntitlementsOnResourceAsync()
    {
        var result = _client.EntitlementService.GetUserEntitlementsOnResourceAsync(UserId, ResourceId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateEntitlementsAsync()
    {
        var userId = string.Empty;
        var resourceId = string.Empty;
        var body = new EntitlementsDataForModification();
        var result = _client.EntitlementService.UpdateEntitlementsAsync(userId, resourceId, body)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteEntitlementsAsync()
    {
        var userId = string.Empty;
        var resourceId = string.Empty;
        var result = _client.EntitlementService.DeleteEntitlementsAsync(userId, resourceId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void AddEntitlementsByResourceAsync()
    {
        var resourceId = string.Empty;
        var body = new UserRoleMappingDataList();
        var result = _client.EntitlementService.AddEntitlementsByResourceAsync(resourceId, body)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateEntitlementsByResourceAsync()
    {
        var resourceId = string.Empty;
        var body = new EntitlementListData();
        var result = _client.EntitlementService.UpdateEntitlementsByResourceAsync(resourceId, body)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteEntitlementsByResourceAsync()
    {
        var resourceId = string.Empty;
        var result = _client.EntitlementService.DeleteEntitlementsByResourceAsync(resourceId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetEntitlementsByResourceAsync()
    {
        var result = _client.EntitlementService.GetEntitlementsByResourceAsync(ResourceId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result)}");
    }
}