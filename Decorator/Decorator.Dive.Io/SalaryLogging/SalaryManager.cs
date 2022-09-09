using Decorator.Dive.Io.Interfaces;

namespace Decorator.Dive.Io.SalaryLogging;

public class SalaryManager
{
    private readonly IDataSource dataSource;

    public SalaryManager(IDataSource dataSource)
    {
        this.dataSource = dataSource;
    }

    public string Load()
    {
        return dataSource.Read();
    }

    public void Save(SalaryRecord record)
    {
        dataSource.Write(record.ToString());
    }
}
