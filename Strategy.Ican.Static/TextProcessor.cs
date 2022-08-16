using Strategy.Ican.Common.ListFormattingStrategies.Interface;

namespace Strategy.Ican.Static;

public class TextProcessor<TListFormattingStrategy>
    where TListFormattingStrategy : IListFormattingStrategy, new()
{
    private readonly TListFormattingStrategy? listFormattingStrategy;

    public TextProcessor()
    {
        listFormattingStrategy = new TListFormattingStrategy();
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
