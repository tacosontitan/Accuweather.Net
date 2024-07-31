// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

using Weatherstack.Net;

namespace Weatherstack.Locations;

/// <summary>
///     Represents the response to be received from the
///     <see href="https://weatherstack.com/documentation#location_lookup">
///         location lookup
///     </see>
///     endpoint of the Weatherstack API.
/// </summary>
public sealed class LocationLookupResponse
    : ApiResponse<LocationLookupRequest>
{
    /// <summary>
    ///     Gets or sets the locations returned by the request.
    /// </summary>
    [JsonPropertyName("locations")]
    public ReadOnlyCollection<Location>? Locations { get; set; }
}
