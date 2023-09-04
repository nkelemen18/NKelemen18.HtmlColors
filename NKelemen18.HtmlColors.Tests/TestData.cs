using System.Linq;

namespace NKelemen18.HtmlColors.Tests;

internal static class TestData
{
    public static TheoryData<string> ValidHexColorData => new()
    {
        "#aacc",
        "#acdc",
        "#ff0",
        "#ff00",
        "#ff00ff",
        "#ff00ff00",
        "#fea100",
        "#f98e1f",
        "#e46119",
        "#fc3769",
        "#9e4784",
        "#89326f",
        "#4d1e40",
        "#5694f1",
        "#78b600",
        "#568300",
        "#f2f2ea",
        "#e8e6da",
        "#807067",
        "#6b5b54",
        "#352f2b",
        "#4c3000",
        "#336699",
        "#369",
        "#336699FF",
        "#369F",
    };

    public static TheoryData<string> InvalidHexColorData => new()
    {
        "#ff00f",
        "#ff00ff0",
        "rgb(-100, -10 0 )",
        "rgb(-100 -10 0 , , ,)",
        "hsl(100%, 100%, 100%, 1009)",
        "rgb(0,0,0,1.2)",
        "rgb(0,   0  ,  0 ,   1.2)",
        "rgba(0,0,0, 1.2)",
        "hsl(-100, -10 0 )",
        "hsl(-100 -10 0 , , ,)",
        "hsl(0,0,0,1.2)",
        "hsl(0,   0  ,  0 ,   1.2)",
        "hsla(0,0,0, 1.2)"
    };

    public static TheoryData<string> InvalidHtmlColorNameData => new()
    {
        "badass",
        "mistyMountain",
        "blueindigo",
        "deeppurple",
        "babyblue",
        "militarygreen",
    };

    public static TheoryData<string> InvalidRgbColorsData => new()
    {
        "rgb(-100, -10, 0 )",
        "rgb(-100 -10 0 , , ,)",
        "rgb(-100, -10 0 )",
        "rgb(0,   0  ,  0 ,   1.2)",
        "rgb(0, 0, 0)foo",
        "rgb(0,0,0,1.2)",
        "rgba(0, 0, 0,  1)foo",
        "rgba(0,0,0, 1.2)",
    };

    public static TheoryData<string> ValidRgbColorsData => new()
    {
        "rgb(0, 255, 255)",
        "rgb(0, 255, 255, 1)",
        "rgb(0, 255, 255, 100%)",
        "rgb(0%, 100%, 100%)",
        "rgb(0%, 100%, 100%, 1)",
        "rgb(0%, 100%, 100%, 100%)",
        "rgb(0 255 255)",
        "rgb(0 255 255 / 1)",
        "rgb(0 255 255 / 100%)",
        "rgb(0% 100% 100%)",
        "rgb(0% 100% 100% / 1)",
        "rgb(0% 100% 100% / 0.8)",
        "rgb(0% 100% 100% / .8)",
        "rgb(0% 100% 100% / 100%)",
        "rgb(0, 0, 0)",
        "rgb(  0, 0, 0 )",
        "rgb(100%, 100%, 100%)",
        "rgb(0,0,0, 0.4)",
        "rgb(0,0,0, 0.499)",
        "rgb(0,       0  , 0                          )",
    };

    public static TheoryData<string> ValidRgbaColorsData => new()
    {
        "rgba(0, 255, 255)",
        "rgba(0, 255, 255, 1)",
        "rgba(0, 255, 255, 100%)",
        "rgba(0%, 100%, 100%)",
        "rgba(0%, 100%, 100%, 1)",
        "rgba(0%, 100%, 100%, 100%)",
        "rgba(0 255 255)",
        "rgba(0 255 255 / 1)",
        "rgba(0 255 255 / 100%)",
        "rgba(0% 100% 100%)",
        "rgba(0% 100% 100% / 1)",
        "rgba(0% 100% 100% / 0.8)",
        "rgba(0% 100% 100% / .8)",
        "rgba(0% 100% 100% / 100%)",
        "rgba(0, 0, 0,  1)",
        "rgba(0, 0, 0,  .45)",
        "rgba(0, 0, 0,  .4)",
        "rgba(100%, 100%, 100%, 1)",
        "rgba(100,100,100,0)",
    };

    public static TheoryData<string> HtmlColorsBaseNamesData
    {
        get
        {
            var data = new TheoryData<string>();
            foreach (var htmlColorsBaseName in HtmlColors.HtmlColorsBaseNames)
            {
                data.Add(htmlColorsBaseName);
            }
            return data;
        }
    }

    public static TheoryData<string> HtmlColorsSpecialNamesData
    {
        get
        {
            var data = new TheoryData<string>();
            foreach (var htmlColorsSpecialName in HtmlColors.HtmlColorsSpecialNames)
            {
                data.Add(htmlColorsSpecialName);
            }
            return data;
        }
    }
}