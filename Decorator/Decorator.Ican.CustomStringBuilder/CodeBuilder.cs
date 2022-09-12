using System.Runtime.Serialization;
using System.Text;

namespace Decorator.Ican.CustomStringBuilder;

public class CodeBuilder
{
    protected readonly StringBuilder Builder = new();

    public override string ToString()
    {
        return Builder.ToString();
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        ((ISerializable)Builder).GetObjectData(info, context);
    }

    public CodeBuilder Append(bool value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(byte value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(char value)
    {
        Builder.Append(value);

        return this;
    }

    public unsafe CodeBuilder Append(char* value, int valueCount)
    {
        Builder.Append(value, valueCount);

        return this;
    }

    public CodeBuilder Append(char value, int repeatCount)
    {
        Builder.Append(value, repeatCount);

        return this;
    }

    public CodeBuilder Append(char[]? value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(char[]? value, int startIndex, int charCount)
    {
        Builder.Append(value, startIndex, charCount);

        return this;
    }

    public CodeBuilder Append(decimal value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(double value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(short value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(int value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(long value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(object? value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(ReadOnlyMemory<char> value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(ReadOnlySpan<char> value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(sbyte value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(float value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(string? value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(string? value, int startIndex, int count)
    {
        Builder.Append(value, startIndex, count);

        return this;
    }

    public CodeBuilder Append(CodeBuilder? value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(CodeBuilder? value, int startIndex, int count)
    {
        Builder.Append(value?.Builder, startIndex, count);

        return this;
    }

    public CodeBuilder Append(ushort value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(uint value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(ulong value)
    {
        Builder.Append(value);

        return this;
    }

    public CodeBuilder Append(ref StringBuilder.AppendInterpolatedStringHandler handler)
    {
        Builder.Append(ref handler);

        return this;
    }

    public CodeBuilder Append(IFormatProvider? provider, ref StringBuilder.AppendInterpolatedStringHandler handler)
    {
        Builder.Append(provider, ref handler);

        return this;
    }

    public CodeBuilder AppendFormat(IFormatProvider? provider, string format, object? arg0)
    {
        Builder.AppendFormat(provider, format, arg0);

        return this;
    }

    public CodeBuilder AppendFormat(IFormatProvider? provider, string format, object? arg0, object? arg1)
    {
        Builder.AppendFormat(provider, format, arg0, arg1);

        return this;
    }

    public CodeBuilder AppendFormat(IFormatProvider? provider, string format, object? arg0, object? arg1, object? arg2)
    {
        Builder.AppendFormat(provider, format, arg0, arg1, arg2);

        return this;
    }

    public CodeBuilder AppendFormat(IFormatProvider? provider, string format, params object?[] args)
    {
        Builder.AppendFormat(provider, format, args);

        return this;
    }

    public CodeBuilder AppendFormat(string format, object? arg0)
    {
        Builder.AppendFormat(format, arg0);

        return this;
    }

    public CodeBuilder AppendFormat(string format, object? arg0, object? arg1)
    {
        Builder.AppendFormat(format, arg0, arg1);

        return this;
    }

    public CodeBuilder AppendFormat(string format, object? arg0, object? arg1, object? arg2)
    {
        Builder.AppendFormat(format, arg0, arg1, arg2);

        return this;
    }

    public CodeBuilder AppendFormat(string format, params object?[] args)
    {
        Builder.AppendFormat(format, args);

        return this;
    }

    public CodeBuilder AppendJoin(char separator, params object?[] values)
    {
        Builder.AppendJoin(separator, values);

        return this;
    }

    public CodeBuilder AppendJoin(char separator, params string?[] values)
    {
        Builder.AppendJoin(separator, values);

        return this;
    }

    public CodeBuilder AppendJoin(string? separator, params object?[] values)
    {
        Builder.AppendJoin(separator, values);

        return this;
    }

    public CodeBuilder AppendJoin(string? separator, params string?[] values)
    {
        Builder.AppendJoin(separator, values);

        return this;
    }

    public CodeBuilder AppendJoin<T>(char separator, IEnumerable<T> values)
    {
        Builder.AppendJoin(separator, values);

        return this;
    }

    public CodeBuilder AppendJoin<T>(string? separator, IEnumerable<T> values)
    {
        Builder.AppendJoin(separator, values);

        return this;
    }

    public CodeBuilder AppendLine()
    {
        Builder.AppendLine();

        return this;
    }

    public CodeBuilder AppendLine(string? value)
    {
        Builder.AppendLine(value);

        return this;
    }

    public CodeBuilder AppendLine(ref StringBuilder.AppendInterpolatedStringHandler handler)
    {
        Builder.AppendLine(ref handler);

        return this;
    }

    public CodeBuilder AppendLine(IFormatProvider? provider, ref StringBuilder.AppendInterpolatedStringHandler handler)
    {
        Builder.AppendLine(provider, ref handler);

        return this;
    }

    public CodeBuilder Clear()
    {
        Builder.Clear();

        return this;
    }

    public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
    {
        Builder.CopyTo(sourceIndex, destination, destinationIndex, count);
    }

    public void CopyTo(int sourceIndex, Span<char> destination, int count)
    {
        Builder.CopyTo(sourceIndex, destination, count);
    }

    public int EnsureCapacity(int capacity)
    {
        return Builder.EnsureCapacity(capacity);
    }

    public bool Equals(ReadOnlySpan<char> span)
    {
        return Builder.Equals(span);
    }

    public bool Equals(CodeBuilder? sb)
    {
        return Builder.Equals(sb?.Builder);
    }

    public StringBuilder.ChunkEnumerator GetChunks()
    {
        return Builder.GetChunks();
    }

    public CodeBuilder Insert(int index, bool value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Insert(int index, byte value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Insert(int index, char value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Insert(int index, char[]? value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Insert(int index, char[]? value, int startIndex, int charCount)
    {
        Builder.Insert(index, value, startIndex, charCount);

        return this;
    }

    public CodeBuilder Insert(int index, decimal value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Insert(int index, double value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Insert(int index, short value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Insert(int index, int value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Insert(int index, long value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Insert(int index, object? value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Insert(int index, ReadOnlySpan<char> value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Insert(int index, sbyte value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Insert(int index, float value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Insert(int index, string? value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Insert(int index, string? value, int count)
    {
        Builder.Insert(index, value, count);

        return this;
    }

    public CodeBuilder Insert(int index, ushort value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Insert(int index, uint value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Insert(int index, ulong value)
    {
        Builder.Insert(index, value);

        return this;
    }

    public CodeBuilder Remove(int startIndex, int length)
    {
        Builder.Remove(startIndex, length);

        return this;
    }

    public CodeBuilder Replace(char oldChar, char newChar)
    {
        Builder.Replace(oldChar, newChar);

        return this;
    }

    public CodeBuilder Replace(char oldChar, char newChar, int startIndex, int count)
    {
        Builder.Replace(oldChar, newChar, startIndex, count);

        return this;
    }

    public CodeBuilder Replace(string oldValue, string? newValue)
    {
        Builder.Replace(oldValue, newValue);

        return this;
    }

    public CodeBuilder Replace(string oldValue, string? newValue, int startIndex, int count)
    {
        Builder.Replace(oldValue, newValue, startIndex, count);

        return this;
    }

    public string ToString(int startIndex, int length)
    {
        return Builder.ToString(startIndex, length);
    }

    public int Capacity
    {
        get => Builder.Capacity;
        set => Builder.Capacity = value;
    }

    public char this[int index]
    {
        get => Builder[index];
        set => Builder[index] = value;
    }

    public int Length
    {
        get => Builder.Length;
        set => Builder.Length = value;
    }

    public int MaxCapacity => Builder.MaxCapacity;
}
