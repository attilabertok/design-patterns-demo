using Strategy.Ican.Common;
using Strategy.Ican.Common.ListFormattingStrategies;
using Strategy.Ican.Common.ListFormattingStrategies.Interface;

namespace Strategy.Ican.Dynamic;

public class TextProcessor
{
    private IListFormattingStrategy? listFormattingStrategy;

    public void SetOutputFormat(OutputFormat outputFormat)
    {
        listFormattingStrategy = outputFormat switch
        {
            OutputFormat.None => null,
            OutputFormat.Markdown => new MarkdownListFormattingStrategy(),
            OutputFormat.Html => new HtmlListFormattingStrategy(),
            _ => throw new ArgumentOutOfRangeException(nameof(outputFormat), outputFormat, null)
        };
    }

    public void AppendList(IEnumerable<string> items)
    {
        foreach (var item in items)
        {
            listFormattingStrategy?.AddItem(item);
        }
    }

    public string Display()
    {
        return listFormattingStrategy?.Format() ?? string.Empty;
    }
}
