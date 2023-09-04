using FluentAssertions;

namespace NKelemen18.HtmlColors.Tests;

public class HexValidationTest
{
    [Theory]
    [MemberData(nameof(TestData.ValidHexColorData), MemberType = typeof(TestData))]
    public void TestValidHexColors(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsHexHtmlColor(color).Should().BeTrue();
    }

    [Theory]
    [MemberData(nameof(TestData.InvalidHexColorData), MemberType = typeof(TestData))]
    public void TestInValidHexColors(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsHexHtmlColor(color).Should().BeFalse();
    }
}