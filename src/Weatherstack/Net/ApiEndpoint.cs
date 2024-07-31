using System.Net.Http;

namespace Weatherstack.Net;

/// <summary>
///     Represents an endpoint for the Weatherstack API.
/// </summary>
/// <param name="method">
///     The HTTP method to use for the request.
/// </param>
/// <param name="url">
///     The URL to use for the request.
/// </param>
internal abstract class ApiEndpoint(
    HttpMethod method,
    string url)
{
    /// <summary>
    ///     Specifies the HTTP method to use for the request.
    /// </summary>
    public HttpMethod Method { get; } = method;

    /// <summary>
    ///     Specifies the URL to use for the request.
    /// </summary>
    public string Url { get; } = url;
}
