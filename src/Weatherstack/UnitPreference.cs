// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

namespace Weatherstack;

/// <summary>
///     Represents the preferred unit of measurement for the weather data.
/// </summary>
/// <remarks>
///     By default, the API will return all results in metric units. Aside
///     from metric units, other common unit formats are supported as well.
/// </remarks>
public enum UnitPreference
{
    /// <summary>
    ///     Specifies that metric units are preferred (defined as <c>m</c> for metric by the API).
    /// </summary>
    /// <remarks>
    ///     <list type="bullet">
    ///         <item>
    ///             <term>Temperature</term>
    ///             <description>Celsius</description>
    ///         </item>
    ///         <item>
    ///             <term>Wind Speed</term>
    ///             <description>Kilometers per hour</description>
    ///         </item>
    ///         <item>
    ///             <term>Pressure</term>
    ///             <description>Millibars</description>
    ///         </item>
    ///         <item>
    ///             <term>Precipitation</term>
    ///             <description>Millimeters</description>
    ///         </item>
    ///         <item>
    ///             <term>Visibility</term>
    ///             <description>Kilometers</description>
    ///         </item>
    ///         <item>
    ///             <term>Snow Depth</term>
    ///             <description>Centimeters</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    Metric = 0,

    /// <summary>
    ///    Specifies that imperial units are preferred (defined as <c>s</c> for scientific by the API).
    /// </summary>
    /// <remarks>
    ///    <list type="bullet">
    ///        <item>
    ///            <term>Temperature</term>
    ///            <description>Kelvin</description>
    ///        </item>
    ///         <item>
    ///             <term>Wind Speed</term>
    ///             <description>Kilometers per hour</description>
    ///         </item>
    ///         <item>
    ///             <term>Pressure</term>
    ///             <description>Millibars</description>
    ///         </item>
    ///         <item>
    ///             <term>Precipitation</term>
    ///             <description>Millimeters</description>
    ///         </item>
    ///         <item>
    ///             <term>Visibility</term>
    ///             <description>Kilometers</description>
    ///         </item>
    ///         <item>
    ///             <term>Snow Depth</term>
    ///             <description>Centimeters</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    Scientific = 1,

    /// <summary>
    ///     Specifies that imperial units are preferred (defined as <c>f</c> for Fahrenheit by the API).
    /// </summary>
    /// <remarks>
    ///    <list type="bullet">
    ///        <item>
    ///            <term>Temperature</term>
    ///            <description>Fahrenheit</description>
    ///        </item>
    ///         <item>
    ///             <term>Wind Speed</term>
    ///             <description>Miles per hour</description>
    ///         </item>
    ///         <item>
    ///             <term>Pressure</term>
    ///             <description>Millibars</description>
    ///         </item>
    ///         <item>
    ///             <term>Precipitation</term>
    ///             <description>Inches</description>
    ///         </item>
    ///         <item>
    ///             <term>Visibility</term>
    ///             <description>Miles</description>
    ///         </item>
    ///         <item>
    ///             <term>Snow Depth</term>
    ///             <description>Inches</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    Imperial = 2
}
