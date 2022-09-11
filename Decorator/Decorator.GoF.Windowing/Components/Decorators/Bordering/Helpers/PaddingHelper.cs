namespace Decorator.GoF.Windowing.Components.Decorators.Bordering.Helpers;

public class PaddingHelper
{
    public static string AddPadding(string name, int titleLength, int width)
    {
        var padding = GeneratePadding(width, titleLength);
        return $@"/{padding}> {name}: <{padding}\";
    }

    private static string GeneratePadding(int width, int titleLength)
    {
        var paddingLength = (width - titleLength) / 2;

        return new string('-', paddingLength);
    }
}
