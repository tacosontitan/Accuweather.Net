﻿// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

namespace Weatherstack.Security;

/// <summary>
///     Represents a literal token provider that returns a fixed token.
/// </summary>
public sealed class LiteralTokenProvider
    : ITokenProvider
{
    private readonly string _token;

    /// <summary>
    ///     Creates a new <see cref="ITokenProvider"/> instance with the specified literal token.
    /// </summary>
    /// <param name="token">
    ///     The literal token used to connect to the Weatherstack API.
    /// </param>
    /// <exception cref="ArgumentNullException">
    ///     <paramref name="token"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentException">
    ///     <paramref name="token"/> is empty or whitespace.
    /// </exception>
    public LiteralTokenProvider(string token)
    {
        ValidateToken(token);
        _token = token;
    }

    /// <inheritdoc />
    public string GetToken() =>
        _token;

    private static void ValidateToken(string token)
    {
        #if NET6_0_OR_GREATER

        ArgumentNullException.ThrowIfNull(token);

        #else

        if (token is null)
            throw new ArgumentNullException(nameof(token));

        #endif

        #if NET8_0_OR_GREATER

        ArgumentException.ThrowIfNullOrWhiteSpace(token);

        #else

        if (string.IsNullOrWhiteSpace(token))
            throw new ArgumentException("The token cannot be empty or whitespace.", nameof(token));

        #endif
    }
}
