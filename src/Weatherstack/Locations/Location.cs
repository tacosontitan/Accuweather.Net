using System.Text.Json.Serialization;

namespace Weatherstack.Locations;

/// <summary>
///     Represents a location within the Weatherstack API.
/// </summary>
public sealed class Location
{
    /// <summary>
    ///     Gets or sets the name of the location.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    ///     Gets or sets the country of the location.
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    ///     Gets or sets the region of the location.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    ///     Gets or sets the latitude of the location.
    /// </summary>
    [JsonPropertyName("lat")]
    public double? Latitude { get; set; }

    /// <summary>
    ///     Gets or sets the longitude of the location.
    /// </summary>
    [JsonPropertyName("lon")]
    public double? Longitude { get; set; }

    /// <summary>
    ///     Gets or sets the timezone id of the location.
    /// </summary>
    [JsonPropertyName("timezone_id")]
    public string? TimezoneId { get; set; }

    /// <summary>
    ///     Gets or sets the UTC offset of the location.
    /// </summary>
    [JsonPropertyName("utc_offset")]
    public double? UtcOffset { get; set; }

    /// <summary>
    ///     Gets or sets the local time of the location.
    /// </summary>
    [JsonPropertyName("localtime")]
    public DateTimeOffset? LocalTime { get; set; }

    /// <summary>
    ///     Gets or sets the local time epoch of the location.
    /// </summary>
    [JsonPropertyName("localtime_epoch")]
    public long? LocalTimeEpoch { get; set; }
}