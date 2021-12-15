namespace OpenTemenos.Shared.Models;

public class ApiException : Exception
{
    public int StatusCode { get; }

    public string? Response { get; }

    public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; }

    public ApiException(string message, int statusCode, string? response, IReadOnlyDictionary<string, IEnumerable<string>> headers, Exception? innerException)
        : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response[..(response.Length >= 512 ? 512 : response.Length)]), innerException)
    {
        StatusCode = statusCode;
        Response = response;
        Headers = headers;
    }

    public override string ToString()
    {
        return $"HTTP Response: \n\n{Response}\n\n{base.ToString()}";
    }
}

[System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v11.0.0.0))")]
public class ApiException<TResult> : ApiException
{
    public TResult Result { get; }

    public ApiException(string message, int statusCode, string? response, IReadOnlyDictionary<string, IEnumerable<string>> headers, TResult result, Exception? innerException)
        : base(message, statusCode, response, headers, innerException)
    {
        Result = result;
    }
}