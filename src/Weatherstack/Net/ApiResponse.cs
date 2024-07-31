// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

using System.Text.Json.Serialization;

namespace Weatherstack.Net;

/// <summary>
///     Represents a response from the Weatherstack API.
/// </summary>
/// <typeparam name="TRequest">
///     Specifies the type of the request that generated the response.
/// </typeparam>
public abstract class ApiResponse<TRequest>
    where TRequest : ApiRequest
{
    /// <summary>
    ///     Gets or sets the response data.
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    /// <summary>
    ///     Gets or sets the error that occurred during the request, if applicable.
    /// </summary>
    [JsonPropertyName("error")]
    public ApiError? Error { get; set; }

    /// <summary>
    ///     Gets or sets the request that generated this response.
    /// </summary>
    [JsonPropertyName("request")]
    public TRequest? Request { get; set; }
}
