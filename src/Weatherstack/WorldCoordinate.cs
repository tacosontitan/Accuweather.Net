using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

using Weatherstack.Annotations.Suppression;

namespace Weatherstack;

/// <summary>
///     Represents a coordinate in the world.
/// </summary>
public struct WorldCoordinate
    : IEquatable<WorldCoordinate>
{
    /// <summary>
    ///    Gets or sets the latitude of the coordinate.
    /// </summary>
    [JsonPropertyName("lat")]
    public double Latitude { get; set; }
    
    /// <summary>
    ///    Gets or sets the longitude of the coordinate.
    /// </summary>
    [JsonPropertyName("lon")]
    public double Longitude { get; set; }

    /// <inheritdoc/>
    [SuppressMessage(
        category: "Style",
        checkId: "IDE0046",
        Justification = Justifications.GuardClausesShouldNotBeTerse)]
    public override bool Equals(object obj)
    {
        if (obj is not WorldCoordinate other)
            return false;

        return Equals(other);
    }

    public bool Equals(WorldCoordinate other) => Latitude == other.Latitude
        && Longitude == other.Longitude;

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        #if NET6_0_OR_GREATER

        return HashCode.Combine(Latitude, Longitude);

        #else

        return 17
            * 23 + Latitude.GetHashCode()
            * 23 + Longitude.GetHashCode();

        #endif
    }

    public static bool operator ==(WorldCoordinate left, WorldCoordinate right) =>
        left.Equals(right);

    public static bool operator !=(WorldCoordinate left, WorldCoordinate right) =>
        !left.Equals(right);
}
