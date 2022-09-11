using Decorator.GoF.Windowing.Infrastructure.Factories;

namespace Decorator.GoF.Windowing.Infrastructure.Helpers;

public class ScrollBarHelper
{
    public static string AddScrollBarSegment(string line, int lineNumber, int lineCount)
    {
        var scrollBar = VerticalScrollBarBuilder.GetBarCharacter(lineNumber, lineCount);

        return $"{line}{scrollBar}";
    }
}
