namespace OpenTemenos.Shared.Models;

public class QueryErrorResponseBody
{
    /// <summary>The identifier of the error message</summary>
    [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Code { get; set; } = default!;

    /// <summary>The actual t24 error message </summary>
    [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Message { get; set; } = default!;

    /// <summary>The identifier of error type: </summary>
    [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Type { get; set; } = default!;

}