namespace Decorator.GoF.Windowing.Infrastructure.Extensions;

public static class StringExtensions
{
    public static IEnumerable<string> Chunk(this string str, int maxChunkSize)
    {
        for (var i = 0; i < str.Length; i += maxChunkSize)
        {
            yield return str.Substring(i, Math.Min(maxChunkSize, str.Length - i));
        }
    }

    public static IEnumerable<string> ChunkLines(this string? content, int height, int width)
    {
        var lines = content?.Split(Environment.NewLine).Take(height).ToArray() ?? Array.Empty<string>();
        var lineChunks = new List<string>(lines.Length);

        foreach (var line in lines)
        {
            lineChunks.AddRange(line.Chunk(width).ToList());
        }

        return lineChunks;
    }

    public static string PadLine(this string lineChunk, int width)
    {
        var requiredPaddingLength = width - lineChunk.Length;
        var padding = requiredPaddingLength > 0 ? new string(' ', requiredPaddingLength) : string.Empty;

        return $"{lineChunk}{padding}";
    }

    public static string TruncateIfNeeded(this string lineChunk, bool shouldTruncate, int maxWidth)
    {
        return shouldTruncate
            ? lineChunk[..Math.Min(lineChunk.Length, maxWidth)]
            : lineChunk;
    }
}
