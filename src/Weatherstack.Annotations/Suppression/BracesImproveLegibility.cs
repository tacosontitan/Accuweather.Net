// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

namespace Weatherstack.Annotations.Suppression;

public static partial class Justifications
{
    /// <summary>
    /// Describes how braces can improve legibility.
    /// </summary>
    public const string BracesImproveLegibility =
        """
        Expression-bodied members are often easier to read for simple methods, but
        for more complex methods, using braces can improve legibility and make the
        code easier to understand. This can be especially helpful for developers who
        are new to the codebase or who are not familiar with the language or framework.
        """;
}
