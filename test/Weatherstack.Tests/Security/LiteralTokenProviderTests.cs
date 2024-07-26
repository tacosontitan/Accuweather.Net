// Copyright (c) 2024 tacosontitan
// This file is part of the Samsara.Net project, which is distributed under the MIT license.
// See LICENSE for more information.

using Weatherstack.Security;

namespace Weatherstack.Tests.Security;

public sealed class LiteralTokenProviderTests
{
    [Fact]
    public void Constructor_TokenIsNull_ThrowsArgumentNullException()
    {
        _ = Assert.Throws<ArgumentNullException>(TestMethod);

        static void TestMethod() =>
            _ = new LiteralTokenProvider(null!);
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("\t")]
    [InlineData("\n")]
    [InlineData("\r")]
    public void Constructor_TokenIsNullOrWhitespace_ThrowsArgumentException(string token)
    {
        _ = Assert.Throws<ArgumentException>(TestMethod);

        void TestMethod() =>
            _ = new LiteralTokenProvider(token);
    }

    [Fact]
    public void GetToken_ReturnsToken()
    {
        const string expectedResult = "test-token";
        var provider = new LiteralTokenProvider(expectedResult);
        var actualResult = provider.GetToken();
        Assert.Equal(expectedResult, actualResult);
    }
}
