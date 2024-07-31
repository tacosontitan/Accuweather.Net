// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

using Microsoft.Extensions.DependencyInjection;

using Weatherstack.Security;

/*
    The folder containing this file is not intended to be a part of the
    namespace, it is purely for organizational purposes.
*/
namespace Weatherstack;

public static partial class WeatherstackServiceExtensions
{
    private static Dictionary<string, string> CreateBaseParameters(
        this IWeatherstackService source,
        UnitPreference? unitPreference = null,
        LanguagePreference? languagePreference = null)
    {
        var tokenProvider = source.ServiceProvider.GetRequiredService<ITokenProvider>();
        var token = tokenProvider.GetToken();
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
