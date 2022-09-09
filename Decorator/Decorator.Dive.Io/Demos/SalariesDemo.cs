using Bogus;

using Decorator.Dive.Io.Configuration;
using Decorator.Dive.Io.SalaryLogging;

namespace Decorator.Dive.Io.Demos;

public static class SalariesDemo
{
    private const int Lines = 3;

    public static void Run()
    {
        var input = GenerateData().ToList();

        Console.WriteLine("Encryption and compression disabled");
        var config = new ApplicationConfigurator();
        var salaryManager = new SalaryManager(config.GetDataSource());
        Print(input, salaryManager);

        Console.WriteLine("Encryption enabled and compression disabled");
        config.IsEncryptionEnabled = true;
        salaryManager = new SalaryManager(config.GetDataSource());
        Print(input, salaryManager);

        Console.WriteLine("Encryption disabled and compression enabled");
        config.IsEncryptionEnabled = false;
        config.IsCompressionEnabled = true;
        salaryManager = new SalaryManager(config.GetDataSource());
        Print(input, salaryManager);

        Console.WriteLine("Encryption and compression enabled");
        config.IsEncryptionEnabled = true;
        config.IsCompressionEnabled = true;
        salaryManager = new SalaryManager(config.GetDataSource());
        Print(input, salaryManager);
    }

    private static void Print(IEnumerable<SalaryRecord> input, SalaryManager salaryManager)
    {
        foreach (var salaryRecord in input)
        {
            salaryManager.Save(salaryRecord);
        }

        for (var i = 0; i < Lines; i++)
        {
            Console.WriteLine(salaryManager.Load());
        }
    }

    private static IEnumerable<SalaryRecord> GenerateData()
    {
        var factor = new Faker().Random.Int(1, 5);
        return Enumerable.Range(0, Lines)
            .Select(_ => new SalaryRecord(new Faker().Person.FullName, factor * 12_000));
    }
}
