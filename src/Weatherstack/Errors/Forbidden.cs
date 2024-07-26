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
    /// Access is denied because the current subscription plan does not support the requested API function or HTTPS access.
    /// </summary>
    public static ApiError Forbidden => new()
    {
        Code = 403,
        Type = "forbidden",
        Information = "The user's current subscription plan does not support this API function / HTTPS."
    };
}
