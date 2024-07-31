// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

namespace Weatherstack;

/// <summary>
///     Defines conversions to and from <see cref="LanguagePreference"/> values.
/// </summary>
public static class LanguagePreferenceAdapter
{
    /// <summary>
    ///     Converts the specified <see cref="LanguagePreference"/> to its corresponding
    ///     string representation.
    /// </summary>
    /// <param name="languagePreference">
    ///     The <see cref="LanguagePreference"/> to convert to a string.
    /// </param>
    /// <returns>
    ///     The string representation of the specified <paramref name="languagePreference"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown when the specified <paramref name="languagePreference"/> is not recognized.
    /// </exception>
    public static string Convert(LanguagePreference languagePreference) => languagePreference switch
    {
        LanguagePreference.English => "en",
        LanguagePreference.Arabic => "ar",
        LanguagePreference.Bengali => "bn",
        LanguagePreference.Bulgarian => "bg",
        LanguagePreference.ChineseSimplified => "zh",
        LanguagePreference.ChineseTraditional => "zh_tw",
        LanguagePreference.Czech => "cs",
        LanguagePreference.Danish => "da",
        LanguagePreference.Dutch => "nl",
        LanguagePreference.Finnish => "fi",
        LanguagePreference.French => "fr",
        LanguagePreference.German => "de",
        LanguagePreference.Greek => "el",
        LanguagePreference.Hindi => "hi",
        LanguagePreference.Hungarian => "hu",
        LanguagePreference.Italian => "it",
        LanguagePreference.Japanese => "ja",
        LanguagePreference.Javanese => "jv",
        LanguagePreference.Korean => "ko",
        LanguagePreference.Mandarin => "zh_cmn",
        LanguagePreference.Marathi => "mr",
        LanguagePreference.Polish => "pl",
        LanguagePreference.Portuguese => "pt",
        LanguagePreference.Punjabi => "pa",
        LanguagePreference.Romanian => "ro",
        LanguagePreference.Russian => "ru",
        LanguagePreference.Serbian => "sr",
        LanguagePreference.Sinhalese => "si",
        LanguagePreference.Slovak => "sk",
        LanguagePreference.Spanish => "es",
        LanguagePreference.Swedish => "sv",
        LanguagePreference.Tamil => "ta",
        LanguagePreference.Telugu => "te",
        LanguagePreference.Turkish => "tr",
        LanguagePreference.Ukrainian => "uk",
        LanguagePreference.Urdu => "ur",
        LanguagePreference.Vietnamese => "vi",
        LanguagePreference.Wu => "zh_wuu",
        LanguagePreference.Xiang => "zh_hsn",
        LanguagePreference.Cantonese => "zh_yue",
        LanguagePreference.Zulu => "zu",
        _ => throw new ArgumentOutOfRangeException(nameof(languagePreference))
    };

    /// <summary>
    ///     Converts the specified ISO code representation of a language to its corresponding
    ///     <see cref="LanguagePreference"/> value.
    /// </summary>
    /// <param name="isoCode">
    ///     The ISO code representation of the language to convert to a <see cref="LanguagePreference"/>.
    /// </param>
    /// <returns>
    ///     The <see cref="LanguagePreference"/> value corresponding to the specified <paramref name="isoCode"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown when the specified <paramref name="isoCode"/> is not recognized.
    /// </exception>
    public static LanguagePreference Convert(string isoCode) => isoCode switch
    {
        "en" => LanguagePreference.English,
        "ar" => LanguagePreference.Arabic,
        "bn" => LanguagePreference.Bengali,
        "bg" => LanguagePreference.Bulgarian,
        "zh" => LanguagePreference.ChineseSimplified,
        "zh_tw" => LanguagePreference.ChineseTraditional,
        "cs" => LanguagePreference.Czech,
        "da" => LanguagePreference.Danish,
        "nl" => LanguagePreference.Dutch,
        "fi" => LanguagePreference.Finnish,
        "fr" => LanguagePreference.French,
        "de" => LanguagePreference.German,
        "el" => LanguagePreference.Greek,
        "hi" => LanguagePreference.Hindi,
        "hu" => LanguagePreference.Hungarian,
        "it" => LanguagePreference.Italian,
        "ja" => LanguagePreference.Japanese,
        "jv" => LanguagePreference.Javanese,
        "ko" => LanguagePreference.Korean,
        "zh_cmn" => LanguagePreference.Mandarin,
        "mr" => LanguagePreference.Marathi,
        "pl" => LanguagePreference.Polish,
        "pt" => LanguagePreference.Portuguese,
        "pa" => LanguagePreference.Punjabi,
        "ro" => LanguagePreference.Romanian,
        "ru" => LanguagePreference.Russian,
        "sr" => LanguagePreference.Serbian,
        "si" => LanguagePreference.Sinhalese,
        "sk" => LanguagePreference.Slovak,
        "es" => LanguagePreference.Spanish,
        "sv" => LanguagePreference.Swedish,
        "ta" => LanguagePreference.Tamil,
        "te" => LanguagePreference.Telugu,
        "tr" => LanguagePreference.Turkish,
        "uk" => LanguagePreference.Ukrainian,
        "ur" => LanguagePreference.Urdu,
        "vi" => LanguagePreference.Vietnamese,
        "zh_wuu" => LanguagePreference.Wu,
        "zh_hsn" => LanguagePreference.Xiang,
        "zh_yue" => LanguagePreference.Cantonese,
        "zu" => LanguagePreference.Zulu,
        _ => throw new ArgumentOutOfRangeException(nameof(isoCode))
    };
}
