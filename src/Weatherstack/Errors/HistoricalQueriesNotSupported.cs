// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

/*
    The folder containing this file is not intended to be a part of the
    namespace, it is purely for organizational purposes.
*/

namespace Weatherstack;

public static partial class Errors
{
    /// <summary>
    /// Indicates that historical data is not supported on the current subscription plan.
    /// </summary>
    public static ApiError HistoricalQueriesNotSupported => new()
    {
        Code = 603,
        Type = "603_historical_queries_not_supported_on_plan",
        Information = "Historical data is not supported on the current subscription plan."
    };
}
