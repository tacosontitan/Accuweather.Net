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
    /// Indicates that the specified interval value is invalid
    /// </summary>
    public static ApiError InvalidInterval => new()
    {
        Code = 607,
        Type = "607_invalid_interval",
        Information = "An invalid interval value was specified."
    };
}
