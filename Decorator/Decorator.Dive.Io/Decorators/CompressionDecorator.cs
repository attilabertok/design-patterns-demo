using System.IO.Compression;

using Decorator.Dive.Io.Decorators.Base;
using Decorator.Dive.Io.Interfaces;

namespace Decorator.Dive.Io.Decorators;

public class CompressionDecorator :
    DataSourceDecoratorBase
{
    public CompressionDecorator(IDataSource dataSource)
        : base(dataSource)
    {
    }

    public override string Read()
    {
        var rawData = base.Read();
        Console.WriteLine($"compressed data: {rawData}");
        var compressedData = Convert.FromBase64String(rawData);

        using var memoryStream = new MemoryStream(compressedData);
        using var gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
        using var streamReader = new StreamReader(gzipStream);

        return streamReader.ReadToEnd();
    }

    public override void Write(string value)
    {
        using var memoryStream = new MemoryStream();
        using var gzipStream = new GZipStream(memoryStream, CompressionMode.Compress);
        using var streamWriter = new StreamWriter(gzipStream);
        streamWriter.Write(value);
        streamWriter.Flush();
        gzipStream.Flush();

        var compressedValue = memoryStream.ToArray();
        var compressedInput = Convert.ToBase64String(compressedValue);

        base.Write(compressedInput);
    }
}
