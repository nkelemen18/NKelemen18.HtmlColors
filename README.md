# HTML Color validator library for .NET 7

### Installation

This package is available on NuGet: [NKelemen18.HtmlColors](https://www.nuget.org/packages/NKelemen18.HtmlColors)

```shell
nuget install NKelemen18.HtmlColors
```

### Description
:information_source: This project is a port of [Validate Color](https://github.com/dreamyguy/validate-color) :rainbow: by Wallace Sidhrée.

Currently support RGB, RGBA, HEX and 140 HtmlColors

### Usage

```csharp
using NKelemen18.HtmlColors;

// Test RGB colors
Console.WriteLine(HtmlColorValidator.IsRgbHtmlColor("rgb(10)")); // False
Console.WriteLine(HtmlColorValidator.IsRgbOrRgbaHtmlColor("rgba(255, 255, 255)")); // True

// Test Hex colors
Console.WriteLine(HtmlColorValidator.IsHexHtmlColor("#invalid")); // False
Console.WriteLine(HtmlColorValidator.IsHexHtmlColor("#89326f")); // True

// Test HTML color names
Console.WriteLine(HtmlColorValidator.IsBaseHtmlColorName("unknown-pink")); // False
Console.WriteLine(HtmlColorValidator.IsBaseHtmlColorName("darkred")); // True

// Test special HTML color names
Console.WriteLine(HtmlColorValidator.IsSpecialHtmlColorName(HtmlColors.Transparent)); //True
Console.WriteLine(HtmlColorValidator.IsSpecialHtmlColorName("transparent")); // True
Console.WriteLine(HtmlColorValidator.IsSpecialHtmlColorName("unset")); // False
Console.WriteLine(HtmlColorValidator.IsSpecialHtmlColorName("inherit")); // True
Console.WriteLine(HtmlColorValidator.IsSpecialHtmlColorName("darkred")); // False
```


:copyright: Norbert Kelemen

[Icon by Freepik](https://www.freepik.com/icon/color-palette_2919586)