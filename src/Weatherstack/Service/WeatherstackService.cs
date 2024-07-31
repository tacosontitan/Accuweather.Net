// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

using Microsoft.Extensions.Options;

#pragma warning disable IDE0130 // Namespace does not match folder structure

/*
    The folder containing this file is not intended to be a part of the
    namespace, it is purely for organizational purposes.
*/
namespace Weatherstack;

#pragma warning restore IDE0130 // Namespace does not match folder structure

/// <summary>
///     Represents a service for interacting with the Weatherstack API.
/// </summary>
public sealed class WeatherstackService
    : IWeatherstackService
{
    /// <summary>
    ///     Creates a new <see cref="WeatherstackService"/> instance.
    /// </summary>
    /// <param name="options">
    ///     The options for the Weatherstack service.
    /// </param>
    /// <param name="serviceProvider">
    ///     A service provider for resolving dependencies
    ///     when interacting with the Weatherstack API.
    /// </param>
    public WeatherstackService(
        IOptionsMonitor<WeatherstackOptions> options,
        IServiceProvider serviceProvider
    )
    {
        #if NET6_0_OR_GREATER

        ArgumentNullException.ThrowIfNull(options);
        ArgumentNullException.ThrowIfNull(serviceProvider);

        #else

        if (options is null)
            throw new ArgumentNullException(nameof(options));

        if (serviceProvider is null)
            throw new ArgumentNullException(nameof(serviceProvider));

        #endif

        ServiceProvider = serviceProvider;
        Options = options.CurrentValue;
        _ = options.OnChange(UpdateOptions);

        void UpdateOptions(WeatherstackOptions newOptions) =>
            Options = newOptions;
    }

    /// <inheritdoc />
    public IServiceProvider ServiceProvider { get; }

    /// <inheritdoc />
    public WeatherstackOptions Options { get; private set; }
}

