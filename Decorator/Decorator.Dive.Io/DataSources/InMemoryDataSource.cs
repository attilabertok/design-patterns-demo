using Decorator.Dive.Io.Interfaces;

namespace Decorator.Dive.Io.DataSources;

public class InMemoryDataSource :
    IDataSource
{
    private readonly Queue<string> data = new();

    public string Read()
    {
        return data.Count > 0
            ? data.Dequeue()
            : string.Empty;
    }

    public void Write(string value)
    {
        data.Enqueue(value);
    }
}
