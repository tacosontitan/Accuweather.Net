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
    /// Indicates that bulk queries are not supported on the current subscription plan.
    /// </summary>
    public static ApiError BulkQueriesNotSupported => new()
    {
        Code = 604,
        Type = "604_bulk_queries_not_supported_on_plan",
        Information = "Bulk queries are not supported on the current subscription plan."
    };
}
