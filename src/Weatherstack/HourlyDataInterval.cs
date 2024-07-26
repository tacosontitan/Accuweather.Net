// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

namespace Weatherstack;

/// <summary>
///    Represents defined intervals for hourly data.
/// </summary>
public enum HourlyDataInterval
{
    /// <summary>
    ///     Specifies that the interval for hourly data is three hours.
    /// </summary>
    /// <remarks>This is the default interval for the API.</remarks>
    ThreeHours = 0,

    /// <summary>
    ///     Specifies that the interval for hourly data is one hour.
    /// </summary>
    OneHour = 1,

    /// <summary>
    ///     Specifies that the interval for hourly data is six hours.
    /// </summary>
    SixHours = 2,

    /// <summary>
    ///     Specifies that the interval for hourly data is twelve hours.
    /// </summary>
    TwelveHours = 3,

    /// <summary>
    ///     Specifies that the interval for hourly data is twenty-four hours.
    /// </summary>
    TwentyFourHours = 4
}