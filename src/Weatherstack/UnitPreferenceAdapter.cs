// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

namespace Weatherstack;

/// <summary>
///     Defines conversions to and from <see cref="UnitPreference"/> values.
/// </summary>
public static class UnitPreferenceAdapter
{
    /// <summary>
    ///     Converts the specified <see cref="UnitPreference"/> to its corresponding
    ///     string representation.
    /// </summary>
    /// <param name="unitPreference">
    ///     The <see cref="UnitPreference"/> to convert to a string.
    /// </param>
    /// <returns>
    ///     The string representation of the specified <paramref name="unitPreference"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown when the specified <paramref name="unitPreference"/> is not recognized.
    /// </exception>
    public static string Convert(UnitPreference unitPreference) => unitPreference switch
    {
        UnitPreference.Metric => "m",
        UnitPreference.Imperial => "f",
        UnitPreference.Scientific => "s",
        _ => throw new ArgumentOutOfRangeException(nameof(unitPreference))
    };

    /// <summary>
    ///     Converts the specified string representation of a <see cref="UnitPreference"/>
    ///     to its corresponding <see cref="UnitPreference"/> value.
    /// </summary>
    /// <param name="unitPreference">
    ///     The string representation of a <see cref="UnitPreference"/> to convert.
    /// </param>
    /// <returns>
    ///     The <see cref="UnitPreference"/> value corresponding to the specified
    ///    <paramref name="unitPreference"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown when the specified <paramref name="unitPreference"/> is not recognized.
    /// </exception>
    public static UnitPreference Convert(string unitPreference) => unitPreference switch
    {
        "m" => UnitPreference.Metric,
        "f" => UnitPreference.Imperial,
        "s" => UnitPreference.Scientific,
        _ => throw new ArgumentOutOfRangeException(nameof(unitPreference))
    };
}
