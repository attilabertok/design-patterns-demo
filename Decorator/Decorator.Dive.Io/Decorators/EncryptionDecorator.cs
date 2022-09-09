using System.Security.Cryptography;

using Decorator.Dive.Io.Decorators.Base;
using Decorator.Dive.Io.Interfaces;

namespace Decorator.Dive.Io.Decorators;

public class EncryptionDecorator :
    DataSourceDecoratorBase
{
    private readonly Aes aes;

    public EncryptionDecorator(
        IDataSource dataSource)
        : base(dataSource)
    {
        aes = Aes.Create();
    }

    public override string Read()
    {
        var rawData = base.Read();
        Console.WriteLine($"encrypted data: {rawData}");
        var encryptedData = Convert.FromBase64String(rawData);

        var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
        using var memoryStream = new MemoryStream(encryptedData);
        using var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
        using var streamReader = new StreamReader(cryptoStream);

        return streamReader.ReadToEnd();
    }

    public override void Write(string value)
    {
        var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
        using var memoryStream = new MemoryStream();
        using var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
        using var streamWriter = new StreamWriter(cryptoStream);
        streamWriter.Write(value);
        streamWriter.Flush();
        cryptoStream.FlushFinalBlock();
        var encryptedValue = memoryStream.ToArray();
        var encryptedInput = Convert.ToBase64String(encryptedValue);

        base.Write(encryptedInput);
    }
}
