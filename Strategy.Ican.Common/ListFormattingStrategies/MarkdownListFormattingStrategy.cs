using System.Text;
using Strategy.Ican.Common.ListFormattingStrategies.Interface;

namespace Strategy.Ican.Common.ListFormattingStrategies;

public class MarkdownListFormattingStrategy : IListFormattingStrategy
{
    private readonly StringBuilder sb;

    public MarkdownListFormattingStrategy()
    {
        sb = new StringBuilder();
    }

    public void AddItem(string item)
    {
        sb.Append(" * ").AppendLine(item);
    }

    public string Format()
    {
        return sb.ToString();
    }
}
