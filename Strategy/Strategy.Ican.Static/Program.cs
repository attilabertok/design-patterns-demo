using Strategy.Ican.Common.ListFormattingStrategies;
using Strategy.Ican.Static.TextProcessing;

namespace Strategy.Ican.Static;

public static class Program
{
    public static void Main()
    {
        var markdownTextProcessor = new TextProcessor<MarkdownListFormattingStrategy>();
        markdownTextProcessor.AppendList(new[] { "Markdown Item 1", "Markdown Item 2", "Markdown Item 3" });
        Console.WriteLine(markdownTextProcessor.Display());

        var htmlTextProcessor = new TextProcessor<HtmlListFormattingStrategy>();
        htmlTextProcessor.AppendList(new[] { "Html Item 1", "Html Item 2", "Html Item 3" });
        Console.WriteLine(htmlTextProcessor.Display());
    }
}
