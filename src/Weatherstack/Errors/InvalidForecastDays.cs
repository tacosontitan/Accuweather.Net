﻿// Copyright (c) 2024 tacosontitan
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
    /// Indicates that an invalid value was specified for the number of forecast days.
    /// </summary>
    public static ApiError InvalidForecastDays => new()
    {
        Code = 608,
        Type = "608_invalid_forecast_days",
        Information = "An invalid forecast days value was specified."
    };
}
