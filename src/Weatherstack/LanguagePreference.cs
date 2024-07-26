namespace Weatherstack;

/// <summary>
///     Represents the preferred language for the weather data.
/// </summary>
/// <remarks>
///    The API is capable of delivering results in a total of 40
///    world languages.
/// </remarks>
public enum LanguagePreference
{
    /// <summary>
    ///     Specifies that English is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>en</c>.</remarks>
    English = 0,

    /// <summary>
    ///     Specifies that Arabic is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>ar</c>.</remarks>
    Arabic = 1,

    /// <summary>
    ///    Specifies that Bengali is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>bn</c>.</remarks>
    Bengali = 2,

    /// <summary>
    ///    Specifies that Bulgarian is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>bg</c>.</remarks>
    Bulgarian = 3,

    /// <summary>
    ///    Specifies that Chinese Simplified is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>zh</c>.</remarks>
    ChineseSimplified = 4,

    /// <summary>
    ///    Specifies that Chinese Traditional is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>zh_tw</c>.</remarks>
    ChineseTraditional = 5,

    /// <summary>
    ///    Specifies that Czech is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>cs</c>.</remarks>
    Czech = 6,

    /// <summary>
    ///    Specifies that Danish is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>da</c>.</remarks>
    Danish = 7,

    /// <summary>
    ///    Specifies that Dutch is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>nl</c>.</remarks>
    Dutch = 8,

    /// <summary>
    ///    Specifies that Finnish is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>fi</c>.</remarks>
    Finnish = 9,

    /// <summary>
    ///    Specifies that French is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>fr</c>.</remarks>
    French = 10,

    /// <summary>
    ///    Specifies that German is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>de</c>.</remarks>
    German = 11,

    /// <summary>
    ///    Specifies that Greek is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>el</c>.</remarks>
    Greek = 12,

    /// <summary>
    ///    Specifies that Hindi is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>hi</c>.</remarks>
    Hindi = 13,

    /// <summary>
    ///    Specifies that Hungarian is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>hu</c>.</remarks>
    Hungarian = 14,

    /// <summary>
    ///    Specifies that Italian is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>it</c>.</remarks>
    Italian = 15,

    /// <summary>
    ///    Specifies that Japanese is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>ja</c>.</remarks>
    Japanese = 16,

    /// <summary>
    ///    Specifies that Javanese is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>jv</c>.</remarks>
    Javanese = 17,

    /// <summary>
    ///    Specifies that Korean is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>ko</c>.</remarks>
    Korean = 18,

    /// <summary>
    ///    Specifies that Mandarin is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>zh_cmn</c>.</remarks>
    Mandarin = 19,

    /// <summary>
    ///    Specifies that Marathi is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>mr</c>.</remarks>
    Marathi = 20,

    /// <summary>
    ///    Specifies that Polish is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>pl</c>.</remarks>
    Polish = 21,

    /// <summary>
    ///    Specifies that Portuguese is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>pt</c>.</remarks>
    Portuguese = 22,

    /// <summary>
    ///    Specifies that Punjabi is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>pa</c>.</remarks>
    Punjabi = 23,

    /// <summary>
    ///    Specifies that Romanian is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>ro</c>.</remarks>
    Romanian = 24,

    /// <summary>
    ///    Specifies that Russian is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>ru</c>.</remarks>
    Russian = 25,

    /// <summary>
    ///    Specifies that Serbian is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>sr</c>.</remarks>
    Serbian = 26,

    /// <summary>
    ///    Specifies that Sinhalese is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>si</c>.</remarks>
    Sinhalese = 27,

    /// <summary>
    ///    Specifies that Slovak is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>sk</c>.</remarks>
    Slovak = 28,

    /// <summary>
    ///    Specifies that Spanish is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>es</c>.</remarks>
    Spanish = 29,

    /// <summary>
    ///    Specifies that Swedish is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>sv</c>.</remarks>
    Swedish = 30,

    /// <summary>
    ///    Specifies that Tamil is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>ta</c>.</remarks>
    Tamil = 31,

    /// <summary>
    ///    Specifies that Telugu is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>te</c>.</remarks>
    Telugu = 32,

    /// <summary>
    ///    Specifies that Turkish is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>tr</c>.</remarks>
    Turkish = 33,

    /// <summary>
    ///    Specifies that Ukrainian is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>uk</c>.</remarks>
    Ukrainian = 34,

    /// <summary>
    ///    Specifies that Urdu is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>ur</c>.</remarks>
    Urdu = 35,

    /// <summary>
    ///    Specifies that Vietnamese is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>vi</c>.</remarks>
    Vietnamese = 36,

    /// <summary>
    ///    Specifies that Wu (Shanghainese) is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>zh_wuu</c>.</remarks>
    Wu = 37,

    /// <summary>
    ///    Specifies that Xiang is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>zh_hsn</c>.</remarks>
    Xiang = 38,

    /// <summary>
    ///    Specifies that Yue (Cantonese) is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>zh_yue</c>.</remarks>
    Cantonese = 39,

    /// <summary>
    ///    Specifies that Zulu is the preferred language.
    /// </summary>
    /// <remarks>Represented by the ISO code <c>zu</c>.</remarks>
    Zulu = 40
}