using Decorator.Dive.Io.Interfaces;

namespace Decorator.Dive.Io.Decorators.Base;

public abstract class DataSourceDecoratorBase :
    IDataSource
{
    private readonly IDataSource dataSource;

    protected DataSourceDecoratorBase(IDataSource dataSource)
    {
        this.dataSource = dataSource;
    }

    public virtual string Read()
    {
        return dataSource.Read();
    }

    public virtual void Write(string value)
    {
        dataSource.Write(value);
    }
}
