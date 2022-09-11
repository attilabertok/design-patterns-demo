namespace Decorator.GoF.Windowing.Infrastructure.Factories;

public static class BorderFactory
{
    public static Borders CreateLineBorder(string leftBorder, string rightBorder, int count)
    {
        return new Borders(CreateLineBorder(leftBorder, count), CreateLineBorder(rightBorder, count));
    }

    private static string CreateLineBorder(string border, int count)
    {
        return count > 0
            ? string.Concat(Enumerable.Repeat(border, count))
            : string.Empty;
    }
}
