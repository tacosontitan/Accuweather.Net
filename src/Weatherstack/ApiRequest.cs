// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

using System.Text.Json.Serialization;

namespace Weatherstack;

/// <summary>
///     Represents a request to the Weatherstack API.
/// </summary>
public class ApiRequest
{
    /// <summary>
    ///     Gets or sets the token to use for the request.
    /// </summary>
    [JsonPropertyName("access_key")]
    public string? Token { get; set; }

    /// <summary>
    ///     Gets or sets the query to use for the request.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    ///     Gets or sets the language to use for the request.
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    ///     Gets or sets the units to use for the request.
    /// </summary>
    [JsonPropertyName("units")]
    public string? Units { get; set; }

    /// <summary>
    ///     Gets or sets the JSONP callback to use for the request.
    /// </summary>
    [JsonPropertyName("callback")]
    public string? Callback { get; set; }
}
