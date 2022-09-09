using Decorator.Dive.Io.DataSources;
using Decorator.Dive.Io.Decorators;
using Decorator.Dive.Io.Interfaces;

namespace Decorator.Dive.Io.Configuration;

public class ApplicationConfigurator
{
    public bool IsEncryptionEnabled { get; set; }

    public bool IsCompressionEnabled { get; set; }

    public IDataSource GetDataSource()
    {
        IDataSource source = new InMemoryDataSource();
        if (IsCompressionEnabled)
        {
            source = new CompressionDecorator(source);
        }

        if (IsEncryptionEnabled)
        {
            source = new EncryptionDecorator(source);
        }

        return source;
    }
}
