// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

using System.Text.Json.Serialization;

using Weatherstack.Net;

namespace Weatherstack.Locations;

/// <summary>
///     Represents a location lookup request within the Weatherstack API.
/// </summary>
public sealed class LocationLookupRequest
    : ApiRequest
{
    /// <summary>
    ///     Gets or sets number of results returned.
    /// </summary>
    [JsonPropertyName("results")]
    public int? ResultCount { get; set; }
}
