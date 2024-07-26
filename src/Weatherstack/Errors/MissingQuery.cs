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
    /// Indicates that a required query value is missing.
    /// </summary>
    public static ApiError MissingQuery => new()
    {
        Code = 601,
        Type = "601_missing_query",
        Information = "An invalid (or missing) query value was specified."
    };
}
