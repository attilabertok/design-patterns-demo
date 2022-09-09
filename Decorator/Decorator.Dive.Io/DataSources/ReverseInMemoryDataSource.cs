using Decorator.Dive.Io.Interfaces;

namespace Decorator.Dive.Io.DataSources;

public class ReverseInMemoryDataSource :
    IDataSource
{
    private readonly Stack<string> data = new();

    public string Read()
    {
        return data.Count > 0
            ? data.Pop()
            : string.Empty;
    }

    public void Write(string value)
    {
        data.Push(value);
    }
}
