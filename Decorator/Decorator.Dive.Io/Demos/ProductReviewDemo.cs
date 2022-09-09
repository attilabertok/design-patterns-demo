using Bogus;

using Decorator.Dive.Io.DataSources;
using Decorator.Dive.Io.Decorators;
using Decorator.Dive.Io.Interfaces;

namespace Decorator.Dive.Io.Demos;

public static class ProductReviewDemo
{
    private const int Lines = 3;

    public static void Run()
    {
        var input = GenerateData().ToList();

        var dataSource = new InMemoryDataSource();
        Demo(nameof(dataSource), dataSource, input);

        var reverseDataSource = new ReverseInMemoryDataSource();
        Demo(nameof(reverseDataSource), reverseDataSource, input);

        var encryptedDataSource = new EncryptionDecorator(dataSource);
        Demo(nameof(encryptedDataSource), encryptedDataSource, input);

        var compressedDataSource = new CompressionDecorator(dataSource);
        Demo(nameof(compressedDataSource), compressedDataSource, input);

        var compressedEncryptedDataSource = new CompressionDecorator(new EncryptionDecorator(dataSource));
        Demo(nameof(compressedEncryptedDataSource), compressedEncryptedDataSource, input);

        var encryptedCompressedDataSource = new EncryptionDecorator(new CompressionDecorator(dataSource));
        Demo(nameof(encryptedCompressedDataSource), encryptedCompressedDataSource, input);
    }

    private static IEnumerable<string> GenerateData()
    {
        return new Faker().Rant.Reviews("Decorator", Lines);
    }

    private static void Demo(string description, IDataSource dataSource, IEnumerable<string> input)
    {
        foreach (var data in input)
        {
            dataSource.Write(data);
        }

        for (var i = 0; i < Lines; i++)
        {
            Console.WriteLine($"{description} {i}: {dataSource.Read()}");
        }

        Console.WriteLine();
    }
}
