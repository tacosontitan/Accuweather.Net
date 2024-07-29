// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

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
/// <param name="serviceProvider">
///     A service provider for resolving dependencies
///     when interacting with the Weatherstack API.
/// </param>
public sealed class WeatherstackService(IServiceProvider serviceProvider)
    : IWeatherstackService
{
    /// <inheritdoc />
    public IServiceProvider ServiceProvider => serviceProvider;
}

