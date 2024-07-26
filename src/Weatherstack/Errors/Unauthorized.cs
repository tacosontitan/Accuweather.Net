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
    /// User did not supply an access key / invalid access key.
    /// </summary>
    public static ApiError Unauthorized => new()
    {
        Code = 101,
        Type = "unauthorized",
        Information = "User did not supply an access key / invalid access key."
    };
}
