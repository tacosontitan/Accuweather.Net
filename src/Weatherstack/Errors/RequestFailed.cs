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
    /// Indicates that the API request has failed.
    /// </summary>
    public static ApiError RequestFailed => new()
    {
        Code = 615,
        Type = "615_request_failed",
        Information = "API request has failed."
    };
}
