using FluentAssertions;

namespace NKelemen18.HtmlColors.Tests;

public class IsHtmlColorTest
{
    [Theory]
    [MemberData(nameof(TestData.InvalidHexColorData), MemberType = typeof(TestData))]
    public void TestInvalidHex(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsHtmlColor(color).Should().BeFalse();
    }

    [Theory]
    [MemberData(nameof(TestData.InvalidRgbColorsData), MemberType = typeof(TestData))]
    public void TestInvalidRgb(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsHtmlColor(color).Should().BeFalse();
    }

    [Theory]
    [MemberData(nameof(TestData.InvalidHtmlColorNameData), MemberType = typeof(TestData))]
    public void TestInvalidHtmlColorName(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsHtmlColor(color).Should().BeFalse();
    }


    [Theory]
    [MemberData(nameof(TestData.ValidHexColorData), MemberType = typeof(TestData))]
    public void TestValidHexColor(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsHtmlColor(color).Should().BeTrue();
    }

    [Theory]
    [MemberData(nameof(TestData.ValidRgbColorsData), MemberType = typeof(TestData))]
    public void TestValidRgbColor(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsHtmlColor(color).Should().BeTrue();
    }

    [Theory]
    [MemberData(nameof(TestData.ValidRgbaColorsData), MemberType = typeof(TestData))]
    public void TestValidRgbaColor(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsHtmlColor(color).Should().BeTrue();
    }

    [Theory]
    [MemberData(nameof(TestData.HtmlColorsBaseNamesData), MemberType = typeof(TestData))]
    public void TestValidBaseColorName(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsHtmlColor(color).Should().BeTrue();
    }

    [Theory]
    [MemberData(nameof(TestData.HtmlColorsSpecialNamesData), MemberType = typeof(TestData))]
    public void TestValidSpecialColorName(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsHtmlColor(color).Should().BeTrue();
    }
}