namespace Decorator.HeadFirst.Io;

public class LowerCaseInputStream :
    Stream
{
    private readonly Stream stream;

    public LowerCaseInputStream(Stream stream)
    {
        this.stream = stream;
    }

    public override void Flush()
    {
        stream.Flush();
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        var bytesRead = stream.Read(buffer, offset, count);
        for (var i = offset; i < offset + bytesRead; i++)
        {
            var originalCharacter = Convert.ToChar(buffer[i]);
            var lowerCaseCharacter = char.ToLower(originalCharacter);
            buffer[i] = Convert.ToByte(lowerCaseCharacter);
        }

        return bytesRead;
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
        return stream.Seek(offset, origin);
    }

    public override void SetLength(long value)
    {
        stream.SetLength(value);
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
        stream.Write(buffer, offset, count);
    }

    public override bool CanRead => stream.CanRead;

    public override bool CanSeek => stream.CanSeek;

    public override bool CanWrite => stream.CanWrite;

    public override long Length => stream.Length;

    public override long Position
    {
        get => stream.Position;
        set => stream.Position = value;
    }
}
