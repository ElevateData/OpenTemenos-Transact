namespace OpenTemenos.Shared.Models;

/// <summary>QueryErrorResponse</summary>
public class QueryErrorResponse
{
    [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public ErrorHeader? Header { get; set; } = default!;

    [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public QueryErrorResponseBody? Error { get; set; } = default!;

}