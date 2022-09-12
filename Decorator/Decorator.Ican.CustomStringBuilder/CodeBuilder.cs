using System.Text;

namespace Decorator.Ican.CustomStringBuilder;

public partial class CodeBuilder
{
    protected StringBuilder Builder { get; } = new();

    public static implicit operator CodeBuilder(string input)
    {
        var instance = new CodeBuilder();
        instance.AppendLine(input);

        return instance;
    }

    public static CodeBuilder operator +(CodeBuilder instance, string input)
    {
        instance.AppendLine(input);

        return instance;
    }

    public override string ToString()
    {
        return Builder.ToString();
    }
}
