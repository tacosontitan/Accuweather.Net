// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

namespace Weatherstack;

/// <summary>
///     Represents the options for the Weatherstack service.
/// </summary>
public sealed class WeatherstackOptions
{
    /// <summary>
    ///     Gets or sets the token to use for the request.
    /// </summary>
    public string? Token { get; set; }

    /// <summary>
    ///     Gets or sets the language to use for the request.
    /// </summary>
    public LanguagePreference? LanguagePreference { get; set; }

    /// <summary>
    ///     Gets or sets the units to use for the request.
    /// </summary>
    public UnitPreference? UnitPreference { get; set; }
}
