// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

using Weatherstack.Annotations.Suppression;

namespace Weatherstack;

/// <summary>
/// Represents an error in the Weatherstack ecosystem.
/// </summary>
public sealed class ApiError
{
    /// <summary>
    /// Gets or sets the code used to identify the error.
    /// </summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>
    /// Gets or sets the type of error that occurred.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the message that describes the error.
    /// </summary>
    [JsonPropertyName("info")]
    public string? Information { get; set; }

    /// <inheritdoc/>
    [SuppressMessage(
        category: "Style",
        checkId: "IDE0046",
        Justification = Justifications.GuardClausesShouldNotBeTerse)]
    public override bool Equals(object? obj)
    {
        if (obj is not ApiError error)
            return false;

        return Code == error.Code;
    }

    /// <inheritdoc/>
    [SuppressMessage(
        category: "Style",
        checkId: "IDE0022",
        Justification = Justifications.BracesImproveLegibility)]
    public override int GetHashCode()
    {
        #if NET6_0_OR_GREATER

        return HashCode.Combine(Code);

        #else

        return 17
            * 23 + Code.GetHashCode();

        #endif
    }
}
