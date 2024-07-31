using System;

namespace Weatherstack;

public static partial class WeatherstackServiceExtensions
{
    private static Dictionary<string, string> CreateBaseParameters(
        this IWeatherstackService source,
        UnitPreference? unitPreference = null,
        LanguagePreference? languagePreference = null)
    {
        var token = source.GetToken();
        var parameters = new Dictionary<string, string>
        {
            ["access_key"] = token
        };

        parameters.AddUnitPreference(unitPreference);
        parameters.AddLanguagePreference(languagePreference);
        return parameters;
    }

    private static void AddUnitPreference(
        this IDictionary<string, string> parameters,
        UnitPreference? unitPreference)
    {
        if (!unitPreference.HasValue)
            return;
        
        var literalValue = UnitPreferenceAdapter.Convert(unitPreference.Value);
        parameters["units"] = literalValue;
    }

    private static void AddLanguagePreference(
        this IDictionary<string, string> parameters,
        LanguagePreference? languagePreference)
    {
        if (!languagePreference.HasValue)
            return;

        var isoCode = LanguagePreferenceAdapter.Convert(languagePreference.Value);
        parameters["language"] = isoCode;
    }
}
