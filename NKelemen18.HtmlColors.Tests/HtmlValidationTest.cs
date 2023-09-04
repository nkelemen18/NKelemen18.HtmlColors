using FluentAssertions;

namespace NKelemen18.HtmlColors.Tests;

public class HtmlValidationTest
{
    [Theory]
    [MemberData(nameof(TestData.HtmlColorsBaseNamesData), MemberType = typeof(TestData))]
    public void TestBaseHtmlColorNamesValid(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsBaseHtmlColorName(color).Should().BeTrue();
    }

    [Theory]
    [MemberData(nameof(TestData.HtmlColorsBaseNamesData), MemberType = typeof(TestData))]
    public void TestBaseHtmlColorInvalidSpecial(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsSpecialHtmlColorName(color).Should().BeFalse();
    }

    [Theory]
    [MemberData(nameof(TestData.HtmlColorsSpecialNamesData), MemberType = typeof(TestData))]
    public void TestSpecialHtmlColorNamesValid(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsSpecialHtmlColorName(color).Should().BeTrue();
    }

    [Theory]
    [MemberData(nameof(TestData.HtmlColorsSpecialNamesData), MemberType = typeof(TestData))]
    public void TestSpecialHtmlColorInvalidBase(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsBaseHtmlColorName(color).Should().BeFalse();
    }

    [Theory]
    [MemberData(nameof(TestData.InvalidHtmlColorNameData), MemberType = typeof(TestData))]
    public void TestInvalidColorNameBaseValidator(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsBaseHtmlColorName(color).Should().BeFalse();
    }

    [Theory]
    [MemberData(nameof(TestData.InvalidHtmlColorNameData), MemberType = typeof(TestData))]
    public void TestInvalidColorNameSpecialValidator(string color)
    {
        // Act && Assert
        HtmlColorValidator.IsSpecialHtmlColorName(color).Should().BeFalse();
    }
}