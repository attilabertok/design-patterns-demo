using Decorator.GoF.Windowing.Infrastructure.Glyphs;

namespace Decorator.GoF.Windowing.Infrastructure.Factories;

public class VerticalScrollBarBuilder
{
    public static string GetBarCharacter(int i, int lineCount)
    {
        return i switch
        {
            0 => VerticalScrollBarComponents.Top,
            1 => VerticalScrollBarComponents.Thumb,
            _ => i == lineCount - 1 ? VerticalScrollBarComponents.Bottom : VerticalScrollBarComponents.Bar
        };
    }
}
