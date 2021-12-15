using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Reference.RoundingRules;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class RoundingRuleServiceTests : CredentialManagement
{
    private const string RuleId = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("GET detail method"), TestCategory("GET detail method")]
    public void GetRoundingRuleDetailsAsync()
    {
        var result = _client.RoundingRuleService.GetRoundingRuleDetailsAsync(RuleId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method"), TestCategory("POST method")]
    public void CreateRoundingRuleDetailsAsync()
    {
        var ruleId = string.Empty;
        var payload = new RoundingRuleDetails();
        var result = _client.RoundingRuleService
            .CreateRoundingRuleDetailsAsync(ruleId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method"), TestCategory("PUT method")]
    public void UpdateRoundingRuleDetailsAsync()
    {
        var ruleId = string.Empty;
        var payload = new RoundingRuleDetails();
        var result = _client.RoundingRuleService
            .UpdateRoundingRuleDetailsAsync(ruleId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method"), TestCategory("DELETE method")]
    public void DeleteRoundingRuleDetailsAsync()
    {
        var ruleId = string.Empty;
        var payload = new RoundingRuleDetailsDelete();
        var result = _client.RoundingRuleService
            .DeleteRoundingRuleDetailsAsync(ruleId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}