using Decorator.GoF.Windowing.Infrastructure;

namespace Decorator.GoF.Windowing.Components.Decorators.Bordering.Helpers;

public class TitleHelper
{
    public static string TruncateIfNeeded(string text, int length, Borders borders)
    {
        var maxLength = length - BorderSize.EmbellishmentLength - borders.Length;

        return ShouldTruncateTitle(text, maxLength)
            ? TruncateTitle(text, maxLength)
            : text;
    }

    public static string PadIfNeeded(string text, Borders borders)
    {
        var padding = HasEvenLength(text, borders)
            ? string.Empty
            : " ";

        return $"{text}{padding}";
    }

    public static int GetTitleLength(string text, Borders borders)
    {
        return text.Length + BorderSize.EmbellishmentLength + borders.Length;
    }

    private static bool HasEvenLength(string text, Borders borders)
    {
        return GetTitleLength(text, borders) % 2 == 0;
    }

    private static bool ShouldTruncateTitle(string text, int maxLength)
    {
        return text.Length > maxLength;
    }

    private static string TruncateTitle(string text, int length)
    {
        return $"{text[..(length - BorderSize.EmbellishmentLength - 2)]}...";
    }
}
