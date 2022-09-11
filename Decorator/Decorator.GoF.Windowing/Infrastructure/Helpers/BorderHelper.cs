namespace Decorator.GoF.Windowing.Infrastructure.Helpers;

public static class BorderHelper
{
    public static string AddBorders(string line, Borders borders)
    {
        return $"{borders.Left}{line}{borders.Right}";
    }
}
