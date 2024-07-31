// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

using Microsoft.Extensions.Options;

namespace Weatherstack.Security;

/// <summary>
///     Represents a token provider that returns a token from an
///     <see cref="IOptionsMonitor{T}"/> instance.
/// </summary>
public sealed class OptionsTokenProvider
    : ITokenProvider
{
    private string? _token;

    /// <summary>
    ///     Creates a new <see cref="ITokenProvider"/> instance focused
    ///     on the token provided by the specified <paramref name="options"/>.
    /// </summary>
    /// <param name="options">
    ///     The options to use for the token.
    /// </param>
    public OptionsTokenProvider(IOptionsMonitor<WeatherstackOptions> options)
    {
        #if NET6_0_OR_GREATER

        ArgumentNullException.ThrowIfNull(options);
        
        #else

        if (options is null)
            throw new ArgumentNullException(nameof(options));

        #endif

        _token = options.CurrentValue.Token;
        options.OnChange(UpdateToken);

        void UpdateToken(WeatherstackOptions options) =>
            _token = options.Token;
    }

    /// <inheritdoc />
    /// <exception cref="ArgumentNullException">
    ///     Thrown when the token is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentException">
    ///     Thrown when the token is empty or whitespace.
    /// </exception>
    public string GetToken()
    {
        ValidateToken(_token);
        return _token!;
    }

    private static void ValidateToken(string? token)
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
