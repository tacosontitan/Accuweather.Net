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
    /// User has reached his subscription's monthly request allowance.
    /// </summary>
    public static ApiError TooManyRequests => new()
    {
        Code = 429,
        Type = "too_many_requests",
        Information = "User has reached his subscription's monthly request allowance."
    };
}
