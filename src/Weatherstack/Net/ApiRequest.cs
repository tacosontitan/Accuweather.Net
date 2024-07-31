// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

using System.Text.Json.Serialization;

namespace Weatherstack.Net;

/// <summary>
///     Represents a request to the Weatherstack API.
/// </summary>
/// <param name="endpoint">
///     The endpoint where the request will be sent.
/// </param>
public abstract class ApiRequest
{


    /// <summary>
    ///     Gets or sets the query to use for the request.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }



    /// <summary>
    ///     Gets or sets the JSONP callback to use for the request.
    /// </summary>
    [JsonPropertyName("callback")]
    public string? Callback { get; set; }
}
