// Copyright (c) 2024 tacosontitan
// This file is part of the Samsara.Net project, which is distributed under the MIT license.
// See LICENSE for more information.

/*
    The folder containing this file is not intended to be a part of the
    namespace, it is purely for organizational purposes.
*/

namespace Weatherstack;

public static partial class Errors
{
    /// <summary>
    /// User requested a resource which does not exist.
    /// </summary>
    public static Error NotFound => new()
    {
        Code = 404,
        Type = "404_not_found",
        Message = "User requested a resource which does not exist."
    };
}
