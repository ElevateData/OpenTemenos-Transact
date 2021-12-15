using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Party.CustomersDocuments;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomersDocumentServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private const string CustomerDocumentId = "1";
    private const string ImageId = "2";
    private const string ImageReference = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetDocumentImageAsync()
    {
        var result = _client.CustomersDocumentService.GetDocumentImageAsync(CustomerId, ImageId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateDocumentImageAsync()
    {
        var customerId = string.Empty;
        var imageId = string.Empty;
        var payload = new DocumentImage();
        var result = _client.CustomersDocumentService.UpdateDocumentImageAsync(customerId, imageId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerImagesAsync()
    {
        var result = _client.CustomersDocumentService.GetCustomerImagesAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateDocumentImageAsync()
    {
        var customerId = string.Empty;
        var payload = new DocumentImage();
        var result = _client.CustomersDocumentService.CreateDocumentImageAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerDocumentAsync()
    {
        var result = _client.CustomersDocumentService.GetCustomerDocumentAsync(CustomerDocumentId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateCustomerDocumentAsync()
    {
        var customerDocumentId = string.Empty;
        var payload = new CustomerDocument();
        var result = _client.CustomersDocumentService.CreateCustomerDocumentAsync(customerDocumentId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void AmendCustomerDocumentAsync()
    {
        var customerDocumentId = string.Empty;
        var payload = new CustomerDocument();
        var result = _client.CustomersDocumentService.AmendCustomerDocumentAsync(customerDocumentId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteCustomerDocumentAsync()
    {
        var customerDocumentId = string.Empty;
        var payload = new CustomerDocumentDelete();
        var result = _client.CustomersDocumentService.DeleteCustomerDocumentAsync(customerDocumentId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetCustomerDocumentsAsync()
    {
        var result = _client.CustomersDocumentService.GetCustomerDocumentsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [TestCategory("GET all method")]
    public void GetDocumentsLocationAsync()
    {
        var result = _client.CustomersDocumentService.GetDocumentsLocationAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetDocumentAndImagesAsync()
    {
        var result = _client.CustomersDocumentService.GetDocumentandImagesAsync(ImageReference)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateProfilePictureUploadAsync()
    {
        var uploadId = string.Empty;
        var payload = new ProfilePictureUpload();
        var result = _client.CustomersDocumentService.CreateProfilePictureUploadAsync(uploadId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateProfilePictureUploadAsync()
    {
        var uploadId = string.Empty;
        var payload = new ProfilePictureUpload();
        var result = _client.CustomersDocumentService.UpdateProfilePictureUploadAsync(uploadId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteProfilePictureUploadAsync()
    {
        var uploadId = string.Empty;
        var payload = new ProfilePictureUploadDelete();
        var result = _client.CustomersDocumentService.DeleteProfilePictureUploadAsync(uploadId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateDocumentAndImageAsync()
    {
        var payload = new DocumentandImage();
        var result = _client.CustomersDocumentService.CreateDocumentandImageAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateDocumentAndImageAsync()
    {
        var documentId = string.Empty;
        var payload = new DocumentandImage();
        var result = _client.CustomersDocumentService.UpdateDocumentandImageAsync(documentId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteDocumentAndImageAsync()
    {
        var documentId = string.Empty;
        var payload = new DocumentandImageDelete();
        var result = _client.CustomersDocumentService.DeleteDocumentandImageAsync(documentId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}