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
    /// Indicates that a historical date is missing.
    /// </summary>
    public static ApiError MissingHistoricalDate => new()
    {
        Code = 614,
        Type = "614_missing_historical_date",
        Information = "An invalid historical date was specified."
    };
}
