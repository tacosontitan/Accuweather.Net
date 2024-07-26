// Copyright (c) 2024 tacosontitan
// This file is part of the Samsara.Net project, which is distributed under the MIT license.
// See LICENSE for more information.

namespace Weatherstack.Security;

/// <summary>
///     Provides a method for getting a bearer token used to access the Weatherstack API.
/// </summary>
public interface ITokenProvider
{
    /// <summary>
    ///     Gets a bearer token for accessing the Weatherstack API.
    /// </summary>
    /// <returns>
    ///    A <see cref="string"/> containing the bearer token.
    /// </returns>
    string GetToken();
}
