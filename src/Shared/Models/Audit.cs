namespace OpenTemenos.Shared.Models;

public partial class Audit
{
    /// <summary>Time taken to response by T24</summary>
    [Newtonsoft.Json.JsonProperty("T24_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? T24_time { get; set; } = default!;

    /// <summary>The CURR.NO. of the record</summary>
    [Newtonsoft.Json.JsonProperty("versionNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? VersionNumber { get; set; } = default!;

    /// <summary>Time taken to parse the request by IRIS</summary>
    [Newtonsoft.Json.JsonProperty("requestParse_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public double? RequestParse_time { get; set; } = default!;

    /// <summary>Time taken to parse the response by IRIS</summary>
    [Newtonsoft.Json.JsonProperty("responseParse_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public double? ResponseParse_time { get; set; } = default!;


}