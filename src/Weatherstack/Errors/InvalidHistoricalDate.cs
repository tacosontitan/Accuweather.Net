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
    /// Indicates that the specified historical date is invalid.
    /// </summary>
    public static ApiError InvalidHistoricalDate => new()
    {
        Code = 611,
        Type = "611_invalid_historical_date",
        Information = "An invalid historical date was specified."
    };
}
