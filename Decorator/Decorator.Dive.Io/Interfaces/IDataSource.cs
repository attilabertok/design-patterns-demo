namespace Decorator.Dive.Io.Interfaces;

public interface IDataSource
{
    string Read();

    void Write(string value);
}
