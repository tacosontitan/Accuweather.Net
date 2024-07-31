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
public interface IWeatherstackService
{
    /// <summary>
    ///     Gets a <see cref="IServiceProvider"/> for resolving dependencies
    ///     when interacting with the Weatherstack API.
    /// </summary>
    IServiceProvider ServiceProvider { get; }

    /// <summary>
    ///     Gets the options for the Weatherstack service.
    /// </summary>
    WeatherstackOptions Options { get; }
}