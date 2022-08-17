namespace Strategy.Ican.Common.ListFormattingStrategies.Interface;

public interface IListFormattingStrategy
{
    void AddItem(string item);

    string Format();
}
