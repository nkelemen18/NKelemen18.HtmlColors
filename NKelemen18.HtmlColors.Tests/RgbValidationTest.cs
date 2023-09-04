using FluentAssertions;

namespace NKelemen18.HtmlColors.Tests;

public class RgbValidationTest
{
    [Theory]
    [MemberData(nameof(TestData.ValidRgbColorsData), MemberType = typeof(TestData))]
    public void TestValidRgbColors(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsRgbHtmlColor(color).Should().BeTrue();
    }

    [Theory]
    [MemberData(nameof(TestData.InvalidRgbColorsData), MemberType = typeof(TestData))]
    public void TestInvalidRgbColors(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsRgbHtmlColor(color).Should().BeFalse();
    }

    [Theory]
    [MemberData(nameof(TestData.ValidRgbaColorsData), MemberType = typeof(TestData))]
    public void TestValidRgbaColors(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsRgbaHtmlColor(color).Should().BeTrue();
    }

    [Theory]
    [MemberData(nameof(TestData.InvalidRgbColorsData), MemberType = typeof(TestData))]
    public void TestInvalidRgbaColors(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsRgbaHtmlColor(color).Should().BeFalse();
    }

    [Theory]
    [MemberData(nameof(TestData.ValidRgbaColorsData), MemberType = typeof(TestData))]
    public void TestRgbaInvalidRgb(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsRgbHtmlColor(color).Should().BeFalse();
    }

    [Theory]
    [MemberData(nameof(TestData.ValidRgbColorsData), MemberType = typeof(TestData))]
    public void TestRgbInvalidRgba(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsRgbaHtmlColor(color).Should().BeFalse();
    }


    [Theory]
    [MemberData(nameof(TestData.ValidRgbColorsData), MemberType = typeof(TestData))]
    public void TestValidRgbOrRgbaWithRgb(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsRgbOrRgbaHtmlColor(color).Should().BeTrue();
    }

    [Theory]
    [MemberData(nameof(TestData.ValidRgbaColorsData), MemberType = typeof(TestData))]
    public void TestValidRgbOrRgbaWithRgba(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsRgbOrRgbaHtmlColor(color).Should().BeTrue();
    }


    [Theory]
    [MemberData(nameof(TestData.InvalidRgbColorsData), MemberType = typeof(TestData))]
    public void TestInvalidRgbOrRgba(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsRgbOrRgbaHtmlColor(color).Should().BeFalse();
    }
}