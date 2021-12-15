namespace OpenTemenos.Shared.Models;

public class ErrorHeader
{
    [Newtonsoft.Json.JsonProperty("audit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public Audit? Audit { get; set; } = default!;

    /// <summary>Status of the API(success/failed)</summary>
    [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Status { get; set; } = default!;

}