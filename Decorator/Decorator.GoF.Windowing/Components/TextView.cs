using Decorator.GoF.Windowing.Components.Base;
using Decorator.GoF.Windowing.Infrastructure;
using Decorator.GoF.Windowing.Infrastructure.Extensions;
using Decorator.GoF.Windowing.Infrastructure.Factories;
using Decorator.GoF.Windowing.Infrastructure.Glyphs;
using Decorator.GoF.Windowing.Infrastructure.Helpers;

namespace Decorator.GoF.Windowing.Components;

public class TextView :
    VisualComponentBase
{
    public TextView()
        : base("Text view")
    {
    }

    public string? Content { get; set; }

    public override void Draw()
    {
        var borders = BorderFactory.CreateLineBorder(Border.Left, Border.Right, SideBorderCount);
        var internalHeight = DetermineLineCount();
        var internalWidth = InternalWidth;
        var hasVerticalScrollbar = HasVerticalScrollbar;
        var lineChunks = ChunkLines(internalHeight);
        var lineCount = Math.Min(internalHeight, lineChunks.Count);

        for (var i = 0; i < lineCount; i++)
        {
            var rawLine = lineChunks[i];
            var line = PrepareLine(rawLine, i, lineCount, hasVerticalScrollbar, internalWidth, borders);
            Console.WriteLine(line);
        }
    }

    /// <remarks>
    /// Because of the way the console works, this class needs to do things that it should not do in a GUI application.
    /// </remarks>
    private static string PrepareLine(
        string rawLine,
        int lineNumber,
        int lineCount,
        bool hasVerticalScrollbar,
        int internalWidth,
        Borders borders)
    {
        var paddedLine = rawLine.TruncateIfNeeded(hasVerticalScrollbar, internalWidth)
            .PadLine(internalWidth);

        var line = hasVerticalScrollbar
            ? ScrollBarHelper.AddScrollBarSegment(paddedLine, lineNumber, lineCount)
            : paddedLine;

        return BorderHelper.AddBorders(line, borders);
    }

    private List<string> ChunkLines(int internalHeight)
    {
        var linesToDisplay = HasVerticalScrollbar
            ? Content?.Split(Environment.NewLine)
            : Content?.ChunkLines(internalHeight, InternalWidth);

        return linesToDisplay?
            .Take(internalHeight)
            .ToList() ?? Enumerable.Empty<string>().ToList();
    }

    private int DetermineLineCount()
    {
        var originalLineCount = Content?.Split(Environment.NewLine).Length ?? 0;

        return HasVerticalScrollbar
            ? originalLineCount
            : InternalHeight;
    }
}
