using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace NKelemen18.HtmlColors;

[SuppressMessage("ReSharper", "UnusedMember.Global")]
[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
public static class HtmlColorValidator
{
    public const string HtmlColorPatternHex = @"^#([\da-f]{3}){1,2}$|^#([\da-f]{4}){1,2}$";

    public const string HtmlColorPatternRgb =
        @"rgb\((\s*\d+%?\s*?,?\s*){2}(\s*\d+%?\s*?,?\s*\)?)(\s*,?\s*\/?\s*(0?\.?\d+%?\s*)?|1|0)?\)$";

    public const string HtmlColorPatternRgba =
        @"rgba\((\s*\d+%?\s*?,?\s*){2}(\s*\d+%?\s*?,?\s*\)?)(\s*,?\s*\/?\s*(0?\.?\d+%?\s*)?|1|0)?\)$";

    public const string HtmlColorPatternRgbOrRgba =
        @"(rgb)a?\((\s*\d+%?\s*?,?\s*){2}(\s*\d+%?\s*?,?\s*\)?)(\s*,?\s*\/?\s*(0?\.?\d+%?\s*)?|1|0)?\)$";


    public static bool IsHtmlColor(string color)
    {
        return IsHexHtmlColor(color) ||
               IsRgbOrRgbaHtmlColor(color) ||
               IsBaseHtmlColorName(color) ||
               IsSpecialHtmlColorName(color);
    }

    public static bool IsBaseHtmlColorName(string color)
    {
        return HtmlColors.HtmlColorsBaseNames.Contains(color, StringComparer.OrdinalIgnoreCase);
    }

    public static bool IsSpecialHtmlColorName(string color)
    {
        return HtmlColors.HtmlColorsSpecialNames.Contains(color,
            StringComparer.OrdinalIgnoreCase);
    }

    public static bool IsHexHtmlColor(string color)
    {
        return Regex.IsMatch(color, HtmlColorPatternHex, RegexOptions.IgnoreCase);
    }

    public static bool IsRgbHtmlColor(string color)
    {
        return Regex.IsMatch(color, HtmlColorPatternRgb, RegexOptions.IgnoreCase);
    }

    public static bool IsRgbaHtmlColor(string color)
    {
        return Regex.IsMatch(color, HtmlColorPatternRgba, RegexOptions.IgnoreCase);
    }

    public static bool IsRgbOrRgbaHtmlColor(string color)
    {
        return Regex.IsMatch(color, HtmlColorPatternRgbOrRgba, RegexOptions.IgnoreCase);
    }
}