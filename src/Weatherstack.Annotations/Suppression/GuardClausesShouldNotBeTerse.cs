// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

namespace Weatherstack.Annotations.Suppression;

public static partial class Justifications
{
    /// <summary>
    /// Guard clauses should not be terse.
    /// </summary>
    public const string GuardClausesShouldNotBeTerse =
        """
        Condensing guard clauses with ternary expressions and similar methods can
        result in a loss of clarity and can make it difficult for less experienced
        developers to understand the intent of the code. This can lead to bugs and
        other issues that are difficult to diagnose and resolve.
        """;
}
