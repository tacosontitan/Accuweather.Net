// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

/*
    The folder containing this file is not intended to be a part of the
    namespace, it is purely for organizational purposes.
*/

namespace Weatherstack.Errors;
public static partial class Errors
{
    /// <summary>
    /// Indicates that the specified historical time frame is invalid.
    /// </summary>
    public static ApiError InvalidHistoricalTimeFrame => new()
    {
        Code = 612,
        Type = "612_invalid_historical_time_frame",
        Information = "An invalid historical time frame was specified."
    };
}
