// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

using System.Net.Http;

using Weatherstack.Net;

namespace Weatherstack.Locations;

/// <summary>
///     Defines the
///     <see href="https://weatherstack.com/documentation#location_lookup">
///         location lookup
///     </see>
///     endpoint for the Weatherstack API.
/// </summary>
internal sealed class LocationLookupEndpoint()
    : ApiEndpoint(
        method: HttpMethod.Get,
        url: "https://api.weatherstack.com/autocomplete");
