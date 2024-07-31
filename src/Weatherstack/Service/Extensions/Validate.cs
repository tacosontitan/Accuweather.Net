// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

using System.Diagnostics.CodeAnalysis;

using Weatherstack.Annotations.Suppression;

/*
    The folder containing this file is not intended to be a part of the
    namespace, it is purely for organizational purposes.
*/
namespace Weatherstack;

/// <summary>
///     Defines extension methods for the <see cref="IWeatherstackService"/>
///     interface to simplify interactions with the Weatherstack API.
/// </summary>
public static partial class WeatherstackServiceExtensions
{
    private static void Validate(this IWeatherstackService source)
    {
        AssertNotNull(source);
        ValidateServiceProvider(source);
    }

    [SuppressMessage(
        category: "Style",
        checkId: "IDE0022",
        Justification = Justifications.BracesImproveLegibility)]
    private static void AssertNotNull(IWeatherstackService service)
    {
        #if NET6_0_OR_GREATER

        ArgumentNullException.ThrowIfNull(service);

        #else

        if (service is null)
            throw new ArgumentNullException(nameof(service));

        #endif
    }

    private static void ValidateServiceProvider(IWeatherstackService source)
    {
        const string errorMessage = "The service provider cannot be null.";
        if (source.ServiceProvider is null)
            throw new InvalidOperationException(errorMessage);
    }
}
