namespace OpenTemenos.Shared.Data;

public static class DefaultConfig
{
    public static string BaseUrl { get; set; } = "https://api.temenos.com/api/v1.0.0/";
    public static bool ReadResponseAsString = false;
}
