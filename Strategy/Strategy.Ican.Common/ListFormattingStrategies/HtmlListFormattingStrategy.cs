using System.Text;

using Strategy.Ican.Common.ListFormattingStrategies.Interface;
using Strategy.Ican.Common.Lists;

namespace Strategy.Ican.Common.ListFormattingStrategies;

public class HtmlListFormattingStrategy : IListFormattingStrategy
{
    private readonly List<string> items = new();

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public string Format()
    {
        var sb = new StringBuilder();
        sb.AppendLine(HtmlTag.List.Start);

        foreach (var item in items)
        {
            AppendItem(sb, item);
        }

        sb.AppendLine(HtmlTag.List.End);

        return sb.ToString();
    }

    private static void AppendItem(StringBuilder sb, string item)
    {
        sb.Append(HtmlTag.ListItem.Start).Append(item).AppendLine(HtmlTag.ListItem.End);
    }
}
