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
    /// Indicates that the specified historical time frame exceeds the maximum allowed limit of 60 days.
    /// </summary>
    public static ApiError HistoricalTimeFrameTooLong => new()
    {
        Code = 613,
        Type = "613_historical_time_frame_too_long",
        Information = "The specified historical time frame is too long. (Maximum: 60 days)"
    };
}
